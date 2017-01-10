#pragma once
#include "datastructures.h"

void recalcNodeList(shared_ptr<vector<uint16_t>> list);
void recalcNode(uint16_t nodeNumber);
void turnTransistorOn(uint16_t tn);
void turnTransistorOff(uint16_t tn);
void addRecalcNode(uint16_t nn);
void getNodeGroup(uint16_t nn);
void addNodeToGroup(uint16_t nn);
bool getNodeValue();
DllExport bool isNodeHigh(uint16_t nn);
DllExport bool isTransistorOn(char* transistorName);
string getStateString();
void setState(string str);
void setFloat(string name);
void setHigh(string name);
void setLow(string name);
shared_ptr<vector<uint16_t>> allNodes();