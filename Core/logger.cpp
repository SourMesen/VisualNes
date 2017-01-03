#include "stdafx.h"
#include <thread>

std::thread loggingThread;
ofstream out;

//vector<string> logVars;
vector<int> logBuffer;

void flushLog(vector<string> logVars, vector<int> logBuffer)
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

		out.flush();
	});
}

void startLogging()
{
	out.open("out.txt", ios::out | ios::binary);
}

void stopLogging()
{
	if(loggingThread.joinable()) {
		loggingThread.join();
	}
	out.close();
}
