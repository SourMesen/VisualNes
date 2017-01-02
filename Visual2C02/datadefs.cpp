#include "stdafx.h"
#include "datastructures.h"
#include "datadefs.h"

vector<vector<int>> segdefs;
vector<transdef> transdefs;
unordered_map<string, int> nodenames;

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
	ifstream file("../Visual2C02/segdefs.txt", ios::in | ios::binary);

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
	ifstream file("../Visual2C02/transdefs.txt", ios::in | ios::binary);

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
	ifstream file("../Visual2C02/nodenames.txt", ios::in | ios::binary);

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

void loadDataDefinitions()
{
	loadSegmentDefinitions();
	loadTransistorDefinitions();
	loadNodeNames();
}