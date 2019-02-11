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
#include "datadefs.h"

vector<node> nodes;
vector<transistor> transistors;
uint8_t nodeCount[MaxNodeCount] = {};
uint16_t nodeC1c2s[MaxNodeCount][MaxC1C2Count] = {};
unordered_map<string, uint16_t> transistorIndexByName;
unordered_map<uint16_t, std::string> nodenameByNumber;

void setupNodes() 
{
	int64_t maxID = 0;
	for(size_t i = 0, len = segdefs.size(); i < len; i++) {
		maxID = std::max(maxID, segdefs[i][0]);
	}
	nodes.insert(nodes.end(), maxID + 1, node());

	for(size_t i = 0, len = segdefs.size(); i < len; i++) {
		std::vector<int64_t> &seg = segdefs[i];
		int w = seg[0];

		if(nodes[w].num == EMPTYNODE) {
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
		vector<uint16_t> segments(&seg[3], &seg[seg.size() - 1]);
		nodes[w].segs.push_back(segments);
	}
}

int maxCount = 0;
void setupTransistors()
{
	int i = 0;
	for(transdef &tdef : transdefs) {
		std::string name = tdef.name;
		uint16_t gate = tdef.gate;
		uint16_t c1 = tdef.c1;
		uint16_t c2 = tdef.c2;

		if(c1 == ngnd) { c1 = c2; c2 = ngnd; }
		if(c1 == npwr) { c1 = c2; c2 = npwr; }
		
		nodes[gate].gates.push_back(i);
		if(c1 != npwr && c1 != ngnd) {
			nodeC1c2s[c1][nodeCount[c1]] = i;
			nodeCount[c1]++;
			if(nodeCount[c1] > maxCount) {
				maxCount = nodeCount[c1];
			}
		}
		if(c2 != npwr && c2 != ngnd) {
			nodeC1c2s[c2][nodeCount[c2]] = i;
			nodeCount[c2]++;
			if(nodeCount[c2] > maxCount) {
				maxCount = nodeCount[c2];
			}
		}

		transistors.push_back({ false, c1, c2, gate, name });
		transistorIndexByName[name] = i;
		i++;
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
	setupNodes();
	setupTransistors();
	setupNodeNameList();
}
