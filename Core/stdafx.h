#pragma once
#include <string>
#include <vector>
#include <unordered_map>
#include <unordered_set>
#include <memory>
#include <algorithm>
#include <fstream>
#include <sstream>

#if _MSC_VER
#define DllExport extern "C" __declspec(dllexport)
#else
#define DllExport extern "C" __attribute__((visibility("default")))
#endif

using std::vector;
using std::string;
using std::ios;
using std::shared_ptr;
using std::unordered_map;
using std::unordered_set;
using std::ifstream;
using std::ofstream;