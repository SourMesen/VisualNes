#include "stdafx.h"
#include "datastructures.h"
#include "datadefs.h"

vector<vector<int>> segdefs;
vector<transdef> transdefs;
unordered_map<string, int> nodenames;
vector<vector<vector<int>>> palette_nodes;
vector<vector<vector<int>>> sprite_nodes;

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
	ifstream file("segdefs.txt", ios::in | ios::binary);

	while(file.good()) {
		string lineContent;
		std::getline(file, lineContent);
		if(lineContent.empty()) {
			continue;
		}

		vector<string> values = split(lineContent, ',');
		vector<int> segDef;
		for(string value : values) {
			segDef.push_back(std::stoi(value));
		}
		segdefs.push_back(segDef);
	}
}

void loadTransistorDefinitions()
{
	ifstream file("transdefs.txt", ios::in | ios::binary);

	while(file.good()) {
		string lineContent;
		std::getline(file, lineContent);
		if(lineContent.empty()) {
			continue;
		}

		vector<string> values = split(lineContent, ',');
		vector<string> bbValues = split(values[4], '|');
		vector<int> bb;
		for(string value : bbValues) {
			bb.push_back(std::stoi(value));
		}

		transdef def = {
			values[0],
			std::stoi(values[1]),
			std::stoi(values[2]),
			std::stoi(values[3]),
			bb,
			{},
			false
		};

		transdefs.push_back(def);
	}
}

void loadNodeNames()
{
	ifstream file("nodenames.txt", ios::in | ios::binary);

	while(file.good()) {
		string lineContent;
		std::getline(file, lineContent);
		if(lineContent.empty()) {
			continue;
		}

		vector<string> values = split(lineContent, ',');
		nodenames[values[0]] = stoi(values[1]);
	}
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