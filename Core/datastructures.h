#pragma once
#include "stdafx.h"

constexpr uint16_t EMPTYNODE = 65535;

struct transdef
{
	string name;
	uint16_t gate;
	uint16_t c1;
	uint16_t c2;
};

struct transistor
{
	bool on;
	uint16_t c1;
	uint16_t c2;
	uint16_t gate;
	string name;
};

struct node
{
	bool state = false;
	bool pullup = false;
	bool pulldown = false;
	bool floating = true;
	
	int64_t area = 0;
	uint16_t num = EMPTYNODE;
	vector<uint16_t> gates;
	vector<vector<uint16_t>> segs;
};