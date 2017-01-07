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
#include <iostream>
#include <cstring>
#include "datastructures.h"
#include "chipsim.h"

extern vector<node> nodes;
extern unordered_map<string, shared_ptr<transistor>> transistors;
extern unordered_map<string, int> nodenames;
extern int ngnd;
extern int npwr;

vector<int> processedNodes;
shared_ptr<vector<int>> recalclists[2];
shared_ptr<vector<int>> recalclist;
vector<int> group;

bool groupEmpty = true;
bool hasGnd = false;
bool hasPwr = false;

void recalcNodeList(shared_ptr<vector<int>> list) {
	if(processedNodes.empty()) {
		processedNodes.insert(processedNodes.end(), nodes.size(), 0);
		recalclists[0].reset(new vector<int>(100));
		recalclists[1].reset(new vector<int>(100));
	} else {
		memset(processedNodes.data(), 0, processedNodes.size() * sizeof(int));
		recalclists[0]->clear();
		recalclists[1]->clear();
	}
	recalclist = recalclists[0];

	for(int j = 0; j<100; j++) {		// loop limiter
		if(j == 99) {
			throw std::runtime_error("Maximum loop exceeded");
		}

		for(int nodeNumber : *list) {
			recalcNode(nodeNumber);
		}

		if(groupEmpty) return;

		for(int nodeNumber : *recalclist) {
			processedNodes[nodeNumber] = 0;
		}

		list = recalclist;
		recalclist = (recalclist == recalclists[1]) ? recalclists[0] : recalclists[1];
		recalclist->clear();

		groupEmpty = true;
	}
}

void recalcNode(int nodeNumber) {
	if(nodeNumber == ngnd) return;
	if(nodeNumber == npwr) return;
	getNodeGroup(nodeNumber);
	bool newState = getNodeValue();

	for(int nn : group) {
		node& n = nodes[nn];
		if(n.state != newState) {
			n.state = newState;
			for(shared_ptr<transistor> &t : n.gates) {
				if(n.state) turnTransistorOn(*t);
				else turnTransistorOff(*t);
			}
		}
	}
}

void turnTransistorOn(transistor &t) {
	if(t.on) return;
	t.on = true;
	addRecalcNode(t.c1);
}

void turnTransistorOff(transistor &t) {
	if(!t.on) return;
	t.on = false;
	addRecalcNode(t.c1);
	addRecalcNode(t.c2);
}

void addRecalcNode(int nn) {
	if(nn == ngnd) return;
	if(nn == npwr) return;

	if(!processedNodes[nn]) {
		recalclist->push_back(nn);
		processedNodes[nn] = 1;
	}

	groupEmpty = false;
}

void getNodeGroup(int i) {
	hasGnd = false;
	hasPwr = false;
	group.clear();
	addNodeToGroup(i);
}

void addNodeToGroup(int i) {
	if(i == ngnd) {
		hasGnd = true;
		return;
	}
	if(i == npwr) {
		hasPwr = true;
		return;
	}
	if(find(group.begin(), group.end(), i) != group.end()) return;
	group.push_back(i);

	for(shared_ptr<transistor> &t : nodes[i].c1c2s) {
		if(t->on) {
			addNodeToGroup(t->c1 == i ? t->c2 : t->c1);
		}
	}
}

bool getNodeValue() {
	if(hasGnd && hasPwr) {
		for(int i : group) {
			if(i == 359 || i == 566 || i == 691 || i == 871 || i == 870 || i == 864 || i == 856 || i == 818) {
				hasGnd = hasPwr = false;
				break;
			}
		}
	}

	if(hasGnd) {
		return false;
	} else if(hasPwr) {
		return true;
	}

	int hi_area = 0;
	int lo_area = 0;
	for(int nn : group) {
		node &n = nodes[nn];
		if(n.pullup) return true;
		if(n.pulldown) return false;
		if(n.state) hi_area += n.area;
		else lo_area += n.area;
	}
	return (hi_area > lo_area);
}


bool isNodeHigh(int32_t nn) {
	return(nodes[nn].state);
}

bool isTransistorOn(char* transistorName)
{
	return transistors[transistorName]->on;
}

shared_ptr<vector<int>> allNodes() {
	shared_ptr<vector<int>> result(new vector<int>());
	for(node& node : nodes) {
		if(node.num != npwr && node.num != ngnd && node.num >= 0) {
			result->push_back(node.num);
		}
	}
	return result;
}

string getStateString() {
	char codes[2] = { 'l', 'h' };
	string res;
	for(node& n : nodes) {
		if(n.num < 0) res += 'x';
		else if(n.num == ngnd) res += 'g';
		else if(n.num == npwr) res += 'v';
		else res += codes[n.state ? 1 : 0];
	}
	return res;
}

void setState(string str) {
	unordered_map<char, bool> codes = { {'g', false}, {'h', true}, {'v',true}, {'l', false } };
	for(size_t i = 0; i < str.size(); i++) {
		char c = str[i];
		if(c == 'x') continue;
		bool state = codes[c];
		if(nodes[i].num < 0) continue;

		nodes[i].state = state;
		for(shared_ptr<transistor> &t : nodes[i].gates) {
			t->on = state;
		}
	}
}

void setFloat(string name) {
	int nn = nodenames[name];
	nodes[nn].pullup = false;
	nodes[nn].pulldown = false;
	recalcNodeList(shared_ptr<vector<int>>(new vector<int> { nn }));
}

void setHigh(string name) {
	int nn = nodenames[name];
	nodes[nn].pullup = true;
	nodes[nn].pulldown = false;
	recalcNodeList(shared_ptr<vector<int>>(new vector<int>{ nn }));
}

void setLow(string name) {
	int nn = nodenames[name];
	nodes[nn].pullup = false;
	nodes[nn].pulldown = true;
	recalcNodeList(shared_ptr<vector<int>>(new vector<int>{ nn }));
}

//function arrayContains(arr, el) { return arr.indexOf(el) != -1; }
