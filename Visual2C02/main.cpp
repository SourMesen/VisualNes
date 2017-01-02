#include "stdafx.h"
#include <iostream>
#include "datadefs.h"
#include "macros.h"
#include "wires.h"
#include <thread>

std::thread loggingThread;
ofstream out("out.txt", ios::out | ios::binary);

void log(vector<string> logVars, vector<int> logBuffer)
{
	if(loggingThread.joinable()) {
		loggingThread.join();
	}
	loggingThread = std::thread([=]() {
		int i = 0;
		for(int val : logBuffer) {
			out << logVars[i] + ": " + std::to_string(val) + " ";
			i = (i + 1) % logVars.size();
			if(i == 0) {
				out << "\r\n";
			}
		}
	});
}

int main()
{
	loadDataDefinitions();
	initDataStructures();
	initChip();

	int prevPos = -1;
	vector<string> logVars = { "cycle" ,"hpos", "vpos", "vbl_flag", "vramaddr_t", "vramaddr_v", "io_db", "io_ab", "io_rw", "io_ce", "rd", "wr", "ab", "ale", "db" };

	vector<int> logBuffer;
	for(int i = 0; i < 10000000; i++) {
		step();

		for(size_t j = 0; j < logVars.size(); j++) {
			logBuffer.push_back(readBits(logVars[j], 0));
		}

		if(i % 2728 == 0) {
			int vpos = readBits("vpos", 0);
			int hpos = readBits("hpos", 0);
			int cycle = readBits("cycle", 0);
			std::cout << "cyc: " << std::to_string(cycle) << " hpos: " << std::to_string(hpos) << " vpos: " << std::to_string(vpos);
		}

		if(i % 10000 == 0) {
			log(logVars, logBuffer);
			logBuffer.clear();
		}
	}
	log(logVars, logBuffer);
	loggingThread.join();

	out.close();
	return 0;
}