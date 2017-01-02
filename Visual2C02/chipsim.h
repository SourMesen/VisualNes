#pragma once
#include "datastructures.h"

void recalcNodeList(shared_ptr<vector<int>> list);
void recalcNode(int nodeNumber);
void turnTransistorOn(transistor &t);
void turnTransistorOff(transistor &t);
void addRecalcNode(int nn);
void getNodeGroup(int i);
void addNodeToGroup(int i);
bool getNodeValue();
bool isNodeHigh(int nn);
string getState();
void setState(string str);
void setFloat(string name);
void setHigh(string name);
void setLow(string name);
shared_ptr<vector<int>> allNodes();