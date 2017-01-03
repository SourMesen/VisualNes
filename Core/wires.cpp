/*
Copyright (c) 2010 Brian Silverman, Barry Silverman

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

#include "stdafx.h"
#include "datastructures.h"
#include "wires.h"

extern std::vector<std::vector<int>> segdefs;
extern std::vector<transdef> transdefs;
extern std::unordered_map<std::string, int> nodenames;

vector<node> nodes;
unordered_map<string, shared_ptr<transistor>> transistors;
unordered_map<int, std::string> nodenameByNumber;

int ngnd;
int npwr;

void setupNodes() 
{
	int maxID = 0;
	for(size_t i = 0, len = segdefs.size(); i < len; i++) {
		maxID = std::max(maxID, segdefs[i][0]);
	}
	nodes.insert(nodes.end(), maxID + 1, node());

	for(size_t i = 0, len = segdefs.size(); i < len; i++) {
		std::vector<int> &seg = segdefs[i];
		int w = seg[0];

		if(nodes[w].num == -1) {
			nodes[w].num = w;
			nodes[w].pullup = seg[1] == 1;
			nodes[w].state = false;
			nodes[w].area = 0;
		}
		
		if(w == ngnd) continue;
		if(w == npwr) continue;
		
		int area = seg[seg.size() - 2] * seg[4] - seg[3] * seg[seg.size() - 1];
		for(size_t j = 3; j + 4 < seg.size(); j += 2) {
			area += seg[j] * seg[j + 3] - seg[j + 2] * seg[j - 1];
		}
		if(area < 0) {
			area = -area;
		}
		nodes[w].area += area;
		nodes[w].segs.insert(nodes[w].segs.end(), &seg[3], &seg[seg.size()-1]);
	}
}

void setupTransistors()
{
	for(transdef &tdef : transdefs) {
		std::string name = tdef.name;
		int gate = tdef.gate;
		int c1 = tdef.c1;
		int c2 = tdef.c2;
		std::vector<int> bb = tdef.bb;

		if(c1 == ngnd) { c1 = c2; c2 = ngnd; }
		if(c1 == npwr) { c1 = c2; c2 = npwr; }
		
		shared_ptr<transistor> trans = shared_ptr<transistor>(new transistor { name, false, gate, c1, c2, bb });
		nodes[gate].gates.push_back(trans);
		nodes[c1].c1c2s.push_back(trans);
		nodes[c2].c1c2s.push_back(trans);
		transistors[name] = trans;
	}
}

void setupNodeNameList()
{
	for(auto kvp : nodenames) {
		nodenameByNumber[kvp.second] = kvp.first;
	}
}

std::string nodeName(int nodeNumber) {
	auto result = nodenameByNumber.find(nodeNumber);
	if(result != nodenameByNumber.end()) {
		return result->second;
	}
	return "";
}

void initDataStructures()
{
	ngnd = nodenames["vss"];
	npwr = nodenames["vcc"];

	setupNodes();
	setupTransistors();
	setupNodeNameList();
}

//var frame, chipbg, overlay, hilite, hitbuffer, ctx;
//var chipLayoutIsVisible = true;  // only modified in expert mode
//var hilited = [];

/*
function setupLayerVisibility() {
	var x = document.getElementById('updateShow');
	for(var i = 0; i<x.childNodes.length; i++) {
		if(x.childNodes[i].type == 'checkbox') {
			x.childNodes[i].checked = drawlayers[x.childNodes[i].name];
		}
	}
}

function setupBackground() {
	chipbg = document.getElementById('chipbg');
	chipbg.width = grCanvasSize;
	chipbg.height = grCanvasSize;
	var ctx = chipbg.getContext('2d');
	ctx.fillStyle = '#000000';
	ctx.strokeStyle = 'rgba(255,255,255,0.5)';
	ctx.lineWidth = grLineWidth;
	ctx.fillRect(0, 0, grCanvasSize, grCanvasSize);
	for(var i in segdefs) {
		var seg = segdefs[i];
		var c = seg[2];
		if(drawlayers[c]) {
			ctx.fillStyle = colors[c];
			drawSeg(ctx, segdefs[i].slice(3));
			ctx.fill();
			if((c == 0) || (c == 6)) ctx.stroke();
		}
	}
}

function setupOverlay() {
	overlay = document.getElementById('overlay');
	overlay.width = grCanvasSize;
	overlay.height = grCanvasSize;
	ctx = overlay.getContext('2d');
}

function setupHilite() {
	hilite = document.getElementById('hilite');
	hilite.width = grCanvasSize;
	hilite.height = grCanvasSize;
	var ctx = hilite.getContext('2d');
}

function setupHitBuffer() {
	hitbuffer = document.getElementById('hitbuffer');
	hitbuffer.width = grCanvasSize;
	hitbuffer.height = grCanvasSize;
	hitbuffer.style.visibility = 'hidden';
	var ctx = hitbuffer.getContext('2d');
	ctx.fillStyle = '#FFFFFF';
	ctx.fillRect(0, 0, grCanvasSize, grCanvasSize);
	for(i in nodes) hitBufferNode(ctx, nodes[i].num, nodes[i].segs);
}

function hitBufferNode(ctx, i, w) {
	var low = ((i >> 0) & 0x1F) << 3 | 0x7;
	var mid = ((i >> 5) & 0x1F) << 3 | 0x7;
	var high = ((i >> 10) & 0x1F) << 3 | 0x7;
	ctx.fillStyle = '#' + hexdigit(high) + hexdigit(mid) + hexdigit(low);
	for(i in w) {
		drawSeg(ctx, w[i]);
		ctx.fill();
	}
}

function hexdigit(n) { return '0123456789ABCDEF'.charAt((n >> 4) & 0xF) + '0123456789ABCDEF'.charAt(n & 0xF); }

/////////////////////////
//
// Drawing Runtime
//
/////////////////////////

function refresh() {
	if(!chipLayoutIsVisible) return;
	ctx.clearRect(0, 0, grCanvasSize, grCanvasSize);
	for(i in nodes) {
		if(isNodeHigh(i)) overlayNode(nodes[i].segs);
	}
	hiliteNode(hilited);
}

function overlayNode(w) {
	ctx.fillStyle = 'rgba(255,0,64,0.4)';
	for(i in w) {
		drawSeg(ctx, w[i]);
		ctx.fill();
	}
}

// originally to highlight using a list of node numbers
//   but can now include transistor names
function hiliteNode(n) {
	var ctx = hilite.getContext('2d');
	ctx.clearRect(0, 0, grCanvasSize, grCanvasSize);
	if(n == -1) return;
	hilited = n;

	for(var i in n) {
		if(typeof n[i] != "number") {
			hiliteTrans([n[i]]);
			continue;
		}
		if(isNodeHigh(n[i])) {
			ctx.fillStyle = 'rgba(255,0,0,0.7)';
		} else {
			ctx.fillStyle = 'rgba(255,255,255,0.7)';
		}
		var segs = nodes[n[i]].segs;
		for(var s in segs) { drawSeg(ctx, segs[s]); ctx.fill(); }
	}
}

// highlight a single transistor (additively - does not clear highlighting)
function hiliteTrans(n) {
	var ctx = hilite.getContext('2d');
	ctx.strokeStyle = 'rgba(255,255,255,0.7)';
	ctx.lineWidth = 4
		for(var t in n) {
			var bb = transistors[n[t]].bb
				var segs = [[bb[0], bb[2], bb[1], bb[2], bb[1], bb[3], bb[0], bb[3]]]
				for(var s in segs) { drawSeg(ctx, segs[s]); ctx.stroke(); }
		}
}

function ctxDrawBox(ctx, xMin, yMin, xMax, yMax) {
	var cap = ctx.lineCap;
	ctx.lineCap = "square";
	ctx.beginPath();
	ctx.moveTo(xMin, yMin);
	ctx.lineTo(xMin, yMax);
	ctx.lineTo(xMax, yMax);
	ctx.lineTo(xMax, yMin);
	ctx.lineTo(xMin, yMin);
	ctx.stroke();
	ctx.lineCap = cap;
}

// takes a bounding box in chip coords and centres the display over it
function zoomToBox(xmin, xmax, ymin, ymax) {
	var xmid = (xmin + xmax) / 2;
	var ymid = (ymin + ymax) / 2;
	var x = (xmid + 400) / grChipSize * 600;
	var y = 600 - ymid / grChipSize * 600;
	var zoom = 5;  // pending a more careful calculation
	moveHere([x, y, zoom]);
}

function drawSeg(ctx, seg) {
	var dx = 400;
	ctx.beginPath();
	ctx.moveTo(grScale(seg[0] + dx), grScale(grChipSize - seg[1]));
	for(var i = 2; i<seg.length; i += 2) ctx.lineTo(grScale(seg[i] + dx), grScale(grChipSize - seg[i + 1]));
	ctx.lineTo(grScale(seg[0] + dx), grScale(grChipSize - seg[1]));
}

function findNodeNumber(x, y) {
	var ctx = hitbuffer.getContext('2d');
	var pixels = ctx.getImageData(x*grCanvasSize / 600, y*grCanvasSize / 600, 2, 2).data;
	if(pixels[0] == 0xFF && pixels[1] == 0xFF && pixels[2] == 0xFF) return -1;
	var high = (pixels[0] >> 3) & 0x1F;
	var mid = (pixels[1] >> 3) & 0x1F;
	var low = (pixels[2] >> 3) & 0x1F;
	return (high << 10) + (mid << 5) + low;
}

function clearHighlight() {
	// remove red/white overlay according to logic value
	// for easier layout navigation
	ctx.clearRect(0, 0, grCanvasSize, grCanvasSize);
}

function updateShow(layer, on) {
	drawlayers[layer] = on;
	setupBackground();
}

// we draw the chip data scaled down to the canvas
// and so avoid scaling a large canvas
function grScale(x) {
	return Math.round(x*grCanvasSize / grChipSize);
}

function localx(el, gx) {
	return gx - el.getBoundingClientRect().left;
}

function localy(el, gy) {
	return gy - el.getBoundingClientRect().top;
}

function setStatus() {
	var res = '';
	// pad the arguments to make this a three-line display
	// there must be a clean way to do this
	if(arguments[1] == undefined)arguments[1] = "";
	if(arguments[2] == undefined)arguments[2] = "";
	arguments.length = 3;
	for(var i = 0; i<arguments.length; i++) res = res + arguments[i] + '<br>';
	statbox.innerHTML = res;
}

function setupNodeNameList() {
	for(var i in nodenames)
		nodenamelist.push(i);
}*/
