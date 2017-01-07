#include "stdafx.h"
#include <cstring>
#include "datastructures.h"
#include "wires.h"
#include "chipsim.h"
#include "macros.h"

string nodenamereset = "res";
extern std::unordered_map<std::string, int> nodenames;

uint8_t chrRam[0x2000];
uint8_t nametableRam[4][0x400];
uint8_t cpuRam[0x800];
uint8_t prgRam[0x8000];

//TODO: Add all of these to save states
MirroringType mirroringType;
std::unordered_map<string, bool> chrStatus;
int lastAddress = 0;
int lastData = 0;
int lastCpuDbValue = 0;
int chrAddress = 0;
int cycle = 0;

void initChip(string state, bool softReset)
{
	if(!softReset) {
		memset(cpuRam, 0, sizeof(cpuRam));
		memset(prgRam, 0, sizeof(prgRam));
		memset(chrRam, 0, sizeof(chrRam));
		memset(nametableRam, 0, sizeof(nametableRam));
	}

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

		//CPU reset
		for(int i = 0; i<6; i++) { 
			setHigh("clk0");
			setLow("clk0");
		}

		setLow("cpu_so");
		setHigh("cpu_irq");
		setHigh("cpu_nmi");
		//CPU reset

		recalcNodeList(allNodes());
		for(int i = 0; i < 12*8; i++) {
			setHigh("clk0");
			setLow("clk0");
		}

		setHigh(nodenamereset);
	} else {
		setState(state);
	}

	cycle = 0;
	chrAddress = 0;
	chrStatus["rd"] = 1;
	chrStatus["wr"] = 1;
	chrStatus["ale"] = 0;
}

void halfStep()
{
	bool clk = isNodeHigh(nodenames["clk0"]);

	if(clk) {
		setLow("clk0");
	} else {
		setHigh("clk0");
	}
	
	//Simulate the 74139's logic
	if(isNodeHigh(nodenames["cpu_ab13"]) && !isNodeHigh(nodenames["cpu_ab14"]) && !isNodeHigh(nodenames["cpu_ab15"]) && isNodeHigh(nodenames["cpu_clk0"])) {
		setLow("io_ce");
	} else {
		setHigh("io_ce");
	}

	handleChrBus();

	if(clk != isNodeHigh(nodenames["cpu_clk0"])) {
		if(clk) { 
			handleCpuBusRead(); 
		} else { 
			handleCpuBusWrite();
		}
	}
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

int readPpuAddressBus() {
	if(isNodeHigh(nodenames["ale"])) {
		lastAddress = readBits("ab", 14);
	}
	return lastAddress;
}

int readPpuDataBus() {
	if(!isNodeHigh(nodenames["rd"]) || !isNodeHigh(nodenames["wr"])) {
		lastData = readBits("db", 8);
	}
	return lastData;
}

int getNametable(int a)
{
	int nametable = 0;
	switch(mirroringType) {
		case MirroringType::Vertical: nametable = (a & 0x400) ? 1 : 0; break;
		case MirroringType::Horizontal: nametable = (a & 0x800) ? 1 : 0; break;
		case MirroringType::FourScreens:	nametable = (a & 0xC00) >> 16; break;
		case MirroringType::ScreenAOnly: nametable = 0; break;
		case MirroringType::ScreenBOnly: nametable = 1; break;
	}
	return nametable;
}

uint8_t mPpuRead(int a) {
	a &= 0x3FFF;
	if(a >= 0x3000) {
		a -= 0x1000;
	}
	if(a < 0x2000) {
		return chrRam[a];
	} else {
		return nametableRam[getNametable(a)][a & 0x3FF];
	}
}

void mPpuWrite(int a, int d) {
	a &= 0x3FFF;
	if(a >= 0x3000) {
		a -= 0x1000;
	}

	if(a < 0x2000) {
		chrRam[a] = d;
	} else {
		nametableRam[getNametable(a)][a & 0x3FF] = d;
	}
}

int mCpuRead(int a) {
	if(a < 0x2000) {
		return cpuRam[a & 0x7FF];
	} else if(a >= 0x8000) {
		return prgRam[a - 0x8000];
	} else {
		//TODO: proper open bus implementation
		return lastCpuDbValue;
	}
}

void mCpuWrite(int a, int d) { 
	if(a < 0x2000) {
		cpuRam[a & 0x7FF] = d;
	} else if(a >= 0x8000) {
		prgRam[a - 0x8000] = d;
	} else {
		//External device (i.e PPU)
	}
}

int readCpuAddressBus() { 
	return readBits("cpu_ab", 16); 
}

int readCpuDataBus() { 
	lastCpuDbValue = readBits("cpu_db", 8); 
	return lastCpuDbValue;
}

void writeCpuDataBus(int x) {
	shared_ptr<vector<int>> recalcs(new vector<int>());
	for(int i = 0; i<8; i++) {
		int nn = nodenames["cpu_db" + std::to_string(i)];
		node &n = nodes[nn];
		if((x % 2) == 0) { 
			n.pulldown = true; 
			n.pullup = false; 
		} else { 
			n.pulldown = false; 
			n.pullup = true; 
		}
		recalcs->push_back(nn);
		x >>= 1;
	}
	recalcNodeList(recalcs);
}

void handleCpuBusRead() {
	if(isNodeHigh(nodenames["cpu_rw"])) {
		int a = readCpuAddressBus();
		/*int d = eval(readTriggers[a]);
		if(d == undefined)*/
		int d = mCpuRead(a);

		/*if(isNodeHigh(nodenames['sync'])) {
			eval(fetchTriggers[d]);
		}*/
		writeCpuDataBus(d);
	}
}

void handleCpuBusWrite() {
	if(!isNodeHigh(nodenames["cpu_rw"])) {
		int a = readCpuAddressBus();
		int d = readCpuDataBus();
		//eval(writeTriggers[a]);
		mCpuWrite(a, d);
	}
}

void handleChrBus() {
	std::unordered_map<string, bool> newStatus;

	newStatus["ale"] = isNodeHigh(nodenames["ale"]);
	newStatus["rd"] = isNodeHigh(nodenames["rd"]);
	newStatus["wr"] = isNodeHigh(nodenames["wr"]);
	// rising edge of ALE
	if(!chrStatus["ale"] && newStatus["ale"]) {
		chrAddress = readPpuAddressBus();
	}
	// falling edge of /RD - put bits on bus
	if(chrStatus["rd"] && !newStatus["rd"]) {
		int a = chrAddress;
		/*var d = eval(readTriggers[a]);*/
		//if(d == undefined) {
		uint8_t d = mPpuRead(a);
		writeBits("db", 8, d);
	}
	// rising edge of /RD - float the data bus
	if(!chrStatus["rd"] && newStatus["rd"]) {
		floatBits("db", 8);
	}
	// rising edge of /WR - store data in RAM
	if(!chrStatus["wr"] && newStatus["wr"]) {
		int a = chrAddress;
		int d = readPpuDataBus();
		//eval(writeTriggers[a]);
		mPpuWrite(a, d);
	}
	chrStatus = newStatus;
}

void setMirroringType(MirroringType mirroring)
{
	mirroringType = mirroring;
}