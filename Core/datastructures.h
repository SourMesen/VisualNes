#pragma once
#include "stdafx.h"

struct transdef
{
	string name;
	int gate;
	int c1;
	int c2;
	vector<int> bb;
	vector<int> unused;
	bool unused2;
};

struct transistor
{
	string name;
	bool on;
	int gate;
	int c1;
	int c2;
	vector<int> bb;
};

struct node
{
	vector<vector<int>> segs;
	int num = -1;
	bool pullup = false;
	bool pulldown = false;
	bool state = false;
	vector<shared_ptr<transistor>> gates;
	vector<shared_ptr<transistor>> c1c2s;
	int area = 0;
	bool floating = true;
};