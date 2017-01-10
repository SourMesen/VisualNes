#pragma once
#include "datastructures.h"

constexpr int MaxNodeCount = 34000;
constexpr int MaxC1C2Count = 95;

extern vector<node> nodes;
extern uint8_t nodeCount[34000];
extern uint16_t nodeC1c2s[34000][95];
extern vector<transistor> transistors;
extern unordered_map<string, uint16_t> transistorIndexByName;
extern unordered_map<uint16_t, std::string> nodenameByNumber;

constexpr uint16_t ngnd = 2;
constexpr uint16_t npwr = 1;

void initDataStructures();
