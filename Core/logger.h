#pragma once
#include "stdafx.h"

void flushLog(vector<string> logVars, vector<int> logBuffer);
DllExport bool startLogging(char *filename, bool useHex, bool useCsv);
DllExport void stopLogging();
