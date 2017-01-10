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
#include "datadefs.h"
#include "wires.h"
#include "chipsim.h"

void setBit(int n1, int n2)
{
	if(n1 == -1 || n2 == -1) return;
	for(uint16_t tn : nodes[n1].gates) {
		transistors[tn].on = true;
	}
	for(uint16_t tn : nodes[n2].gates) {
		transistors[tn].on = false;
	}
	nodes[n1].state = true;
	nodes[n2].state = false;

	shared_ptr<vector<uint16_t>> recalcList(new vector<uint16_t> { (uint16_t)n1, (uint16_t)n2 });
	recalcNodeList(recalcList);
}

int palette_read(int addr) {
	int r0 = 0;
	int r1 = 0;
	for(int b = 0; b < 6; b++) {
		int n0 = palette_nodes[addr][b][0];
		int n1 = palette_nodes[addr][b][1];
		if(isNodeHigh(n0)) {
			r0 |= 1 << b;
		}
		if(isNodeHigh(n1)) {
			r1 |= 1 << b;
		}
	}
	int r = r0 | r1;
	if(r != 0x3F) {
		return 0xFF;
	}
	else	return r1;
}

void palette_write(int addr, int val) {
	for(int b = 0; b < 6; b++) {
		int n0 = palette_nodes[addr][b][0];
		int n1 = palette_nodes[addr][b][1];
		if(val & (1 << b))
			setBit(n1, n0);
		else
			setBit(n0, n1);
	}
	//refresh();
}

int sprite_read(int addr) {
	int r0 = 0;
	int r1 = 0;
	for(int b = 0; b < 8; b++) {
		int n0 = sprite_nodes[addr][b][0];
		int n1 = sprite_nodes[addr][b][1];
		if(n0 == -1 || n1 == -1)
			continue;
		if(isNodeHigh(n0))
			r0 |= 1 << b;
		if(isNodeHigh(n1))
			r1 |= 1 << b;
	}
	return r1;
}

void sprite_write(int addr, int val) {
	for(int b = 0; b < 8; b++) {
		int n0 = sprite_nodes[addr][b][0];
		int n1 = sprite_nodes[addr][b][1];
		if(val & (1 << b))
			setBit(n1, n0);
		else
			setBit(n0, n1);
	}
	//refresh();
}