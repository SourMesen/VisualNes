#pragma once
#include "datastructures.h"

extern vector<vector<int>> segdefs;
extern vector<transdef> transdefs;
extern unordered_map<string, uint16_t> nodenames;
extern unordered_map<uint16_t, string> nodenamesById;
extern vector<vector<vector<int>>> palette_nodes;
extern vector<vector<vector<int>>> sprite_nodes;

vector<string> split(const string &s, char delim);
void loadDataDefinitions();
