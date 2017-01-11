#include "stdafx.h"
#include <cstring>
#include "datastructures.h"
#include "wires.h"
#include "chipsim.h"
#include "macros.h"
#include "datadefs.h"

string nodenamereset = "res";

uint8_t chrRam[0x2000];
uint8_t nametableRam[4][0x400];
uint8_t cpuRam[0x800];
uint8_t prgRam[0x8000];
uint32_t ppuFrameBuffer[256 * 240] = {0};
uint32_t ppuPaletteArgb[64] = { 0xFF666666, 0xFF002A88, 0xFF1412A7, 0xFF3B00A4, 0xFF5C007E, 0xFF6E0040, 0xFF6C0600, 0xFF561D00, 0xFF333500, 0xFF0B4800, 0xFF005200, 0xFF004F08, 0xFF00404D, 0xFF000000, 0xFF000000, 0xFF000000, 0xFFADADAD, 0xFF155FD9, 0xFF4240FF, 0xFF7527FE, 0xFFA01ACC, 0xFFB71E7B, 0xFFB53120, 0xFF994E00, 0xFF6B6D00, 0xFF388700, 0xFF0C9300, 0xFF008F32, 0xFF007C8D, 0xFF000000, 0xFF000000, 0xFF000000, 0xFFFFFEFF, 0xFF64B0FF, 0xFF9290FF, 0xFFC676FF, 0xFFF36AFF, 0xFFFE6ECC, 0xFFFE8170, 0xFFEA9E22, 0xFFBCBE00, 0xFF88D800, 0xFF5CE430, 0xFF45E082, 0xFF48CDDE, 0xFF4F4F4F, 0xFF000000, 0xFF000000, 0xFFFFFEFF, 0xFFC0DFFF, 0xFFD3D2FF, 0xFFE8C8FF, 0xFFFBC2FF, 0xFFFEC4EA, 0xFFFECCC5, 0xFFF7D8A5, 0xFFE4E594, 0xFFCFEF96, 0xFFBDF4AB, 0xFFB3F3CC, 0xFFB5EBF2, 0xFFB8B8B8, 0xFF000000, 0xFF000000 };

//TODO: Add all of these to save states
MirroringType mirroringType;
bool prevPpuAle = false;
bool prevPpuWr = true;
bool prevPpuRd = true;
int lastAddress = 0;
int lastData = 0;
int lastCpuDbValue = 0;
int chrAddress = 0;
int cycle = 0;
int prevhpos = -1;

void initChip(string state, bool softReset)
{
	prevhpos = -1;

	if(!softReset) {
		memset(ppuFrameBuffer, 0, sizeof(ppuFrameBuffer));
		memset(cpuRam, 0, sizeof(cpuRam));
		memset(prgRam, 0, sizeof(prgRam));
		memset(chrRam, 0, sizeof(chrRam));
		memset(nametableRam, 0, sizeof(nametableRam));
	}

	if(state.empty()) {
		if(softReset) {
			setLow(nodenamereset);
			for(int i = 0; i < 12 * 8 * 2 + 1; i++) {
				if(isNodeHigh(nodenames["clk0"])) {
					setLow("clk0");
				} else {
					setHigh("clk0");
				}
			}
			setHigh(nodenamereset);
		} else {
			for(node &n : nodes) {
				n.state = false;
				n.floating = true;
			}

			nodes[ngnd].state = false;
			nodes[ngnd].floating = false;
			nodes[npwr].state = true;
			nodes[npwr].floating = false;

			for(transistor &t : transistors) {
				t.on = (t.gate == npwr);
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
		}
	} else {
		setState(state);
	}

	cycle = 0;
	chrAddress = 0;
	prevPpuRd = true;
	prevPpuWr = true;
	prevPpuAle = false;
}

int cycleCount = 0;
void halfStep()
{
	bool cpu_clk0 = isNodeHigh(nodenames["cpu_clk0"]);
	bool clk = isNodeHigh(nodenames["clk0"]);

	if(clk) {
		setLow("clk0");
	} else {
		setHigh("clk0");
	}

	if(cycleCount > 0) {
		cycleCount--;
		if(!cycleCount) {
			setHigh("io_ce");
		}
	} else {
		//Simulate the 74139's logic
		if(cycleCount == 0 && isNodeHigh(nodenames["cpu_ab13"]) && !isNodeHigh(nodenames["cpu_ab14"]) && !isNodeHigh(nodenames["cpu_ab15"]) && isNodeHigh(nodenames["cpu_clk0"])) {
			setLow("io_ce");
			cycleCount = 11;
		}
	}
	handleChrBus();

	if(cpu_clk0 != isNodeHigh(nodenames["cpu_clk0"])) {
		if(cpu_clk0) {
			handleCpuBusRead(); 
		} else { 
			handleCpuBusWrite();
		}
	}

	if(readBits("pclk1")) {
		int hpos = readBits("hpos") - 2;
		if(hpos != prevhpos) {
			int vpos = readBits("vpos");
			if(hpos >= 0 && hpos < 256 && vpos < 240) {
				uint8_t paletteEntry = readBit("pal_d0_out") | (readBit("pal_d1_out") << 1) | (readBit("pal_d2_out") << 2) | (readBit("pal_d3_out") << 3) | (readBit("pal_d4_out") << 4) | (readBit("pal_d5_out") << 5);
				ppuFrameBuffer[(vpos << 8) | hpos] = ppuPaletteArgb[paletteEntry];
			}
			prevhpos = hpos;
		}
	}
}

DllExport void getFrameBuffer(uint8_t* buffer)
{
	memcpy(buffer, ppuFrameBuffer, sizeof(ppuFrameBuffer));
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
	shared_ptr<vector<uint16_t>> recalcs(new vector<uint16_t>());
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
	shared_ptr<vector<uint16_t>> recalcs(new vector<uint16_t>());
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
		case MirroringType::Horizontal: nametable = (a & 0x800) ? 1 : 0; break;
		case MirroringType::Vertical: nametable = (a & 0x400) ? 1 : 0; break;
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

int mCpuRead(int a, bool &openBus) {
	openBus = false;
	if(a < 0x2000) {
		return cpuRam[a & 0x7FF];
	} else if(a >= 0x8000) {
		return prgRam[a - 0x8000];
	} else {
		//TODO: proper open bus implementation
		openBus = true;
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

void handleCpuBusRead() {
	if(isNodeHigh(nodenames["cpu_rw"])) {
		int a = readCpuAddressBus();
		/*int d = eval(readTriggers[a]);
		if(d == undefined)*/
		bool openBus = false;
		int d = mCpuRead(a, openBus);

		/*if(isNodeHigh(nodenames['sync'])) {
			eval(fetchTriggers[d]);
		}*/
		if(openBus) {
			floatBits("cpu_db", 8);
		} else {
			writeBits("cpu_db", 8, d);
		}
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
	bool ale = isNodeHigh(nodenames["ale"]);
	bool rd = isNodeHigh(nodenames["rd"]);
	bool wr = isNodeHigh(nodenames["wr"]);

	// rising edge of ALE
	if(!prevPpuAle && ale) {
		chrAddress = readPpuAddressBus();
	}
	// falling edge of /RD - put bits on bus
	if(prevPpuRd && !rd) {
		/*var d = eval(readTriggers[a]);*/
		//if(d == undefined) {
		writeBits("db", 8, mPpuRead(chrAddress));
	}
	// rising edge of /RD - float the data bus
	if(!prevPpuRd && rd) {
		floatBits("db", 8);
	}
	// rising edge of /WR - store data in RAM
	if(!prevPpuWr && wr) {
		//eval(writeTriggers[a]);
		mPpuWrite(chrAddress, readPpuDataBus());
	}

	readPpuDataBus();

	prevPpuAle = ale;
	prevPpuRd = rd;
	prevPpuWr = wr;
}

void setMirroringType(MirroringType mirroring)
{
	mirroringType = mirroring;
}