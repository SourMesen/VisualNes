#include "stdafx.h"
#include "HexUtilities.h"
#include <thread>

std::thread loggingThread;
ofstream out;
bool logAsHex;
bool logAsCsv;
vector<int> logBuffer;

string toString(int value)
{
	if(logAsHex) {
		return HexUtilities::ToHex((uint32_t)value);
	} else {
		return std::to_string(value);
	}
}

void flushLog(vector<string> logVars, vector<int> logBuffer)
{
	if(out) {
		if(loggingThread.joinable()) {
			loggingThread.join();
		}
		loggingThread = std::thread([=]() {
			int i = 0;
			for(int val : logBuffer) {
				if(logAsCsv) {
					out << toString(val) + ",";
				} else {
					out << logVars[i] + ": " + toString(val) + " ";
				}
				i = (i + 1) % logVars.size();
				if(i == 0) {
					out << "\r\n";
				}
			}

			out.flush();
		});
	}
}

DllExport bool startLogging(char *filename, bool useHex, bool useCsv)
{
	logAsHex = useHex;
	logAsCsv = useCsv;
	out.open(filename, ios::out | ios::binary);
	if(out) {
		return true;
	} else {
		return false;
	}
}

DllExport void stopLogging()
{
	if(out) {
		if(loggingThread.joinable()) {
			loggingThread.join();
		}
		out.close();
	}
}
