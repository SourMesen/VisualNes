#pragma once
#include "stdafx.h"

extern uint8_t memory[0x3000];
extern int cycle;

void initChip(string state);
void halfStep();
void step();
int readBit(string name);
int readBits(string name, int n = 0);
void writeBits(string name, int n, int x);
void writeBit(string name, int x);
void floatBits(string name, int n);
int readAddressBus();
int readDataBus();
uint8_t mRead(int a);
void mWrite(int a, int d);
void handleChrBus();
void handleIoBus();
void resetProgram(vector<uint16_t> newProgram);