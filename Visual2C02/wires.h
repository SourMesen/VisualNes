#pragma once
#include "datastructures.h"

extern vector<node> nodes;
extern unordered_map<string, shared_ptr<transistor>> transistors;
extern unordered_map<int, std::string> nodenameByNumber;

extern int ngnd;
extern int npwr;

void initDataStructures();
//string nodeName(int nodeNumber);
