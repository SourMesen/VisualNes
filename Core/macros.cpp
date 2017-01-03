#pragma once
#include "stdafx.h"
#include "datastructures.h"
#include "wires.h"
#include "chipsim.h"
#include "macros.h"

string nodenamereset = "res";
extern std::unordered_map<std::string, int> nodenames;

uint8_t memory[0x3000];
std::unordered_map<string, bool> chrStatus;
int lastAddress = 0;
int lastData = 0;
int chrAddress = 0;
int cycle = 0;
int ioParms = 0;
int ioCounter = 0;
int testprogramAddress = 0;
vector<uint16_t> testprogram = {
	0x2000, // $00 -> $2000
	0x2100, // $00 -> $2001
	0x2300, // $00 -> $2003, sprite DMA follows
	0x3200, // read $2002
	0x2500, // $00 -> $2005
	0x2500, // $00 -> $2005
	0x2090, // $90 -> $2000
	0x211E,	// $1E -> $2001
	0x00FF, // terminator
};

void initChip(string state)
{
	memset(memory, 0, sizeof(memory));

	if(state.empty()) {
		for(node &n : nodes) {
			n.state = false;
			n.floating = true;
		}

		nodes[ngnd].state = false;
		nodes[ngnd].floating = false;
		nodes[npwr].state = true;
		nodes[npwr].floating = false;

		for(auto kvp : transistors) {
			kvp.second->on = (kvp.second->gate == npwr);
		}

		setLow(nodenamereset);
		setLow("clk0");
		setHigh("io_ce");
		setHigh("int");

		recalcNodeList(allNodes());
		for(int i = 0; i < 4; i++) {
			setHigh("clk0");
			setLow("clk0");
		}

		setHigh(nodenamereset);
	} else {
		setState(state);
	}

	cycle = 0;
	testprogramAddress = 0;
	ioCounter = 0;
	handleIoBus(); // to get it properly synchronized
	chrAddress = 0;
	chrStatus["rd"] = 1;
	chrStatus["wr"] = 1;
	chrStatus["ale"] = 0;
}

void halfStep()
{
	bool clk = isNodeHigh(nodenames["clk0"]);
	//eval(clockTriggers[cycle]);
	handleIoBus();
	if(clk) {
		setLow("clk0");
	} else {
		setHigh("clk0");
	}
	handleChrBus();
}

void step()
{
	halfStep();
	cycle++;
}

int readBit(string name) {
	return isNodeHigh(nodenames[name]) ? 1 : 0;
}

unordered_map<string, vector<int>> nodeNumberCache;
unordered_map<string, int> bitCountCache;
vector<string> numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };

int readBits(string name, int n) {
	if(name.compare("cycle") == 0) {
		return cycle >> 1;
	}
	
	int res = 0;
	if(n == 0) {
		if(name[name.size() - 1] >= '0' && name[name.size() - 1] <= '9') {
			return readBit(name);
		} else {
			auto result = bitCountCache.find(name);
			if(result == bitCountCache.end()) {
				nodeNumberCache[name] = vector<int>();
				while(nodenames.find(name + numbers[n]) != nodenames.end()) {
					nodeNumberCache[name].push_back(nodenames[name + numbers[n]]);
					n++;
				};
				bitCountCache[name] = n;
				if(n == 0 && nodenames.find(name) != nodenames.end()) {
					bitCountCache[name] = 1;
				}
			} else {
				n = result->second;
			}

			if(n == 1) {
				return readBit(name);
			}
		}

		int i = 0;
		for(int nn : nodeNumberCache[name]) {
			res += ((isNodeHigh(nn)) ? 1 : 0) << i;
			i++;
		}
	} else {
		for(int i = 0; i<n; i++) {
			int nn = nodenames[name + numbers[i]];
			res += ((isNodeHigh(nn)) ? 1 : 0) << i;
		}
	}

	return res;
}

void writeBit(string name, int x) {
	if(x) { 
		setHigh(name);
	} else {
		setLow(name);
	}
}

void writeBits(string name, int n, int x) {
	shared_ptr<vector<int>> recalcs(new vector<int>());
	for(int i = 0; i<n; i++) {
		int nn = nodenames[name + std::to_string(i)];
		if((x % 2) == 0) {
			nodes[nn].pulldown = true;
			nodes[nn].pullup = false;
		} else {
			nodes[nn].pulldown = false;
			nodes[nn].pullup = true;
		}
		recalcs->push_back(nn);
		x >>= 1;
	}
	recalcNodeList(recalcs);
}

void floatBits(string name, int n) {
	shared_ptr<vector<int>> recalcs(new vector<int>());
	for(int i = 0; i<n; i++) {
		int nn = nodenames[name + std::to_string(i)];
		nodes[nn].pulldown = false;
		nodes[nn].pullup = false;
		recalcs->push_back(nn);
	}
	recalcNodeList(recalcs);
}

int readAddressBus() {
	if(isNodeHigh(nodenames["ale"])) {
		lastAddress = readBits("ab", 14);
	}
	return lastAddress;
}

int readDataBus() {
	if(!isNodeHigh(nodenames["rd"]) || !isNodeHigh(nodenames["wr"])) {
		lastData = readBits("db", 8);
	}
	return lastData;
}

uint8_t mRead(int a) {
	a &= 0x3FFF;
	if(a >= 0x3000) {
		a -= 0x1000;
	}
	return memory[a];
}

void mWrite(int a, int d) {
	a &= 0x3FFF;
	if(a >= 0x3000) {
		a -= 0x1000;
	}
	memory[a] = d;
}

void handleChrBus() {
	std::unordered_map<string, bool> newStatus;

	newStatus["ale"] = isNodeHigh(nodenames["ale"]);
	newStatus["rd"] = isNodeHigh(nodenames["rd"]);
	newStatus["wr"] = isNodeHigh(nodenames["wr"]);
	// rising edge of ALE
	if(!chrStatus["ale"] && newStatus["ale"]) {
		chrAddress = readAddressBus();
	}
	// falling edge of /RD - put bits on bus
	if(chrStatus["rd"] && !newStatus["rd"]) {
		int a = chrAddress;
		/*var d = eval(readTriggers[a]);*/
		//if(d == undefined) {
		uint8_t d = mRead(a);
		writeBits("db", 8, d);
	}
	// rising edge of /RD - float the data bus
	if(!chrStatus["rd"] && newStatus["rd"]) {
		floatBits("db", 8);
	}
	// rising edge of /WR - store data in RAM
	if(!chrStatus["wr"] && newStatus["wr"]) {
		int a = chrAddress;
		int d = readDataBus();
		//eval(writeTriggers[a]);
		mWrite(a, d);
	}
	chrStatus = newStatus;
}

void handleIoBus() {
	if((ioCounter == 0) && (testprogramAddress < testprogram.size())) {
		//cmd_highlightCurrent();
		ioParms = testprogram[testprogramAddress];
		if(ioParms & 0x3000)
			ioCounter = 24;
		else {
			ioCounter = ioParms & 0x7FF;
			floatBits("io_db", 8);
		}
	}
	if(ioCounter > 0) {
		int ce = (ioParms & 0x2000) >> 13;
		int rw = (ioParms & 0x1000) >> 12;
		int a = (ioParms & 0x700) >> 8;
		int d = (ioParms & 0xFF);
		if((ioCounter == 24) && ce) {
			writeBits("io_ab", 3, a);
			if(rw) { 
				floatBits("io_db", 8); 
			} else {
				writeBits("io_db", 8, d);
			}
			writeBit("io_rw", rw);
		}
		if((ioCounter == 16) && ce) {
			setLow("io_ce");
		}
		if(ioCounter == 1) {
			if(rw) {
				d = readBits("io_db", 8);
				// store result in the test program
				//cmd_setCellValue(testprogramAddress * 8 + 5, d);
			}
			setHigh("io_ce");
		}
		ioCounter--;
		if(ioCounter == 0)
			testprogramAddress++;
	}
}

void resetProgram(vector<uint16_t> newProgram)
{
	testprogram = newProgram;
	testprogramAddress = 0;
}