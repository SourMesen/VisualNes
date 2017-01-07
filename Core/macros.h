#pragma once
#include "stdafx.h"

extern uint8_t chrRam[0x2000];
extern uint8_t nametableRam[4][0x400];
extern uint8_t cpuRam[0x800];
extern uint8_t prgRam[0x8000];
extern int cycle;

enum class MirroringType
{
	Horizontal,
	Vertical,
	ScreenAOnly,
	ScreenBOnly,
	FourScreens
};

void initChip(string state, bool softReset);
void halfStep();
void step();
int readBit(string name);
int readBits(string name, int n = 0);
void writeBits(string name, int n, int x);
void writeBit(string name, int x);
void floatBits(string name, int n);

int readPpuAddressBus();
int readPpuDataBus();
uint8_t mPpuRead(int a);
void mPpuWrite(int a, int d);

int mCpuRead(int a);
void mCpuWrite(int a, int d);
int readCpuAddressBus();
int readCpuDataBus();
void writeCpuDataBus(int x);


void handleChrBus();
void handleCpuBusWrite();
void handleCpuBusRead();

DllExport void setMirroringType(MirroringType mirroringType);