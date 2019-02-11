#include "stdafx.h"
#include "datastructures.h"
#include "datadefs.h"

vector<vector<int64_t>> segdefs;
vector<transdef> transdefs;
unordered_map<string, uint16_t> nodenames;
vector<vector<vector<int>>> palette_nodes;
vector<vector<vector<int>>> sprite_nodes;

//Define connections between CPU and PPU
//Convert some of the CPU nodes into their PPU equivalent (or vice versa)
int cpuOffset = 13000;
unordered_map<uint16_t, uint16_t> idConvertTable{
	{ 10000 + cpuOffset, 1 }, //vcc
	{ 10001 + cpuOffset, 2 }, //vss
	{ 10004 + cpuOffset, 1934 }, //reset

	{ 11669 + cpuOffset, 772 }, //cpu_clk_in -> clk0

	{ 1013, 11819 + cpuOffset }, //io_db0 -> cpu_db0
	{ 765, 11966 + cpuOffset }, //db1
	{ 431, 12056 + cpuOffset }, //db2
	{ 87, 12091 + cpuOffset }, //db3
	{ 11, 12090 + cpuOffset }, //db4
	{ 10, 12089 + cpuOffset }, //db5
	{ 9, 12088 + cpuOffset }, //db6
	{ 8, 12087 + cpuOffset }, //db7

	{ 12, 10020 + cpuOffset }, //io_ab0 -> cpu_ab0
	{ 6, 10019 + cpuOffset }, //io_ab1 -> cpu_ab1
	{ 7, 10030 + cpuOffset }, //io_ab2 -> cpu_ab2

	{ 10331 + cpuOffset, 1031 }, //nmi -> int
	{ 10092 + cpuOffset, 1224 }, //cpu_rw -> io_rw
};

uint16_t convertId(uint16_t id)
{
	auto result = idConvertTable.find(id);
	if(result != idConvertTable.end()) {
		return result->second;
	}
	return id;
}

vector<string> split(const string &s, char delim)
{
	vector<string> tokens;
	std::stringstream ss(s);
	std::string item;
	while(std::getline(ss, item, delim)) {
		tokens.push_back(item);
	}
	return tokens;
}

void loadSegmentDefinitions()
{
	auto loadSegments = [](string filename, int segmentIdOffset) {
		ifstream file(filename, ios::in | ios::binary);

		while(file.good()) {
			string lineContent;
			std::getline(file, lineContent);
			if(lineContent.empty()) {
				continue;
			}

			vector<string> values = split(lineContent, ',');
			vector<int64_t> segDef;
			for(string value : values) {
				if(segDef.empty()) {
					segDef.push_back(convertId(std::stoi(value) + segmentIdOffset));
				} else {
					segDef.push_back(std::stoi(value));
				}
			}
			segdefs.push_back(segDef);
		}
		
		file.close();
	};

	loadSegments("segdefs.txt", 0);
	loadSegments("cpusegdefs.txt", cpuOffset);
}

void loadTransistorDefinitions()
{
	auto loadTransistors = [](string filename, string namePrefix, int segmentIdOffset) {
		ifstream file(filename, ios::in | ios::binary);
		while(file.good()) {
			string lineContent;
			std::getline(file, lineContent);
			if(lineContent.empty()) {
				continue;
			}

			vector<string> values = split(lineContent, ',');
			transdef def = {
				namePrefix + values[0],
				convertId(std::stoi(values[1]) + segmentIdOffset),
				convertId(std::stoi(values[2]) + segmentIdOffset),
				convertId(std::stoi(values[3]) + segmentIdOffset)
			};

			transdefs.push_back(def);
		}
		file.close();
	};

	loadTransistors("transdefs.txt", "", 0);
	loadTransistors("cputransdefs.txt", "cpu_", cpuOffset);
}

void loadNodeNames()
{
	auto load = [](string filename, string nameprefix, int segmentIdOffset) {
		ifstream file(filename, ios::in | ios::binary);
		while(file.good()) {
			string lineContent;
			std::getline(file, lineContent);
			if(lineContent.empty()) {
				continue;
			}

			vector<string> values = split(lineContent, ',');
			nodenames[nameprefix + values[0]] = convertId(stoi(values[1]) + segmentIdOffset);
		}
		file.close();
	};

	load("nodenames.txt", "", 0);
	load("cpunodenames.txt", "cpu_", cpuOffset);
}

void loadPaletteNodes()
{
	ifstream file("palettenodes.txt", ios::in | ios::binary);

	while(file.good()) {
		string lineContent;
		std::getline(file, lineContent);
		if(lineContent.empty()) {
			continue;
		}

		vector<vector<int>> row;
		vector<string> values = split(lineContent, ',');
		for(string &pair : values) {
			vector<string> pairData = split(pair, '|');
			row.push_back({ std::stoi(pairData[0]), std::stoi(pairData[1]) });
		}
		palette_nodes.push_back(row);
	}
}

void loadSpriteNodes()
{
	ifstream file("spritenodes.txt", ios::in | ios::binary);

	while(file.good()) {
		string lineContent;
		std::getline(file, lineContent);
		if(lineContent.empty()) {
			continue;
		}

		vector<vector<int>> row;
		vector<string> values = split(lineContent, ',');
		for(string &pair : values) {
			vector<string> pairData = split(pair, '|');
			row.push_back({ std::stoi(pairData[0]), std::stoi(pairData[1]) });
		}
		sprite_nodes.push_back(row);
	}
}

void loadDataDefinitions()
{
	loadSegmentDefinitions();
	loadTransistorDefinitions();
	loadNodeNames();
	loadPaletteNodes();
	loadSpriteNodes();
}