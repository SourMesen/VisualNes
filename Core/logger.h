#pragma once
#include "stdafx.h"

void flushLog(vector<string> logVars, vector<int> logBuffer);
DllExport bool startLogging(char *filename);
DllExport void stopLogging();
