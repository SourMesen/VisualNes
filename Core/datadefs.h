#pragma once
#include "datastructures.h"

extern vector<vector<int>> segdefs;
extern vector<transdef> transdefs;
extern unordered_map<string, int> nodenames;
extern vector<vector<vector<int>>> palette_nodes;
extern vector<vector<vector<int>>> sprite_nodes;

vector<string> split(const string &s, char delim);
void loadDataDefinitions();
