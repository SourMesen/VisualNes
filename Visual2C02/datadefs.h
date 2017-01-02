#pragma once
#include "datastructures.h"

extern vector<vector<int>> segdefs;
extern vector<transdef> transdefs;
extern unordered_map<string, int> nodenames;

void loadDataDefinitions();
