#include "stdafx.h"
#include <deque>
#include "datadefs.h"
#include "macros.h"
#include "wires.h"
#include "chipsim.h"
#include "ramedit.h"
#include "logger.h"

#if _WIN32 || _WIN64
#define DllExport __declspec(dllexport)
#else
#define DllExport __attribute__((visibility("default")))
#endif

vector<string> logVars = { "cycle" ,"hpos", "vpos", "vbl_flag", "spr0_hit", "spr_overflow", "vramaddr_t", "vramaddr_v", "io_db", "io_ab", "io_rw", "io_ce", "rd", "wr", "ab", "ale", "db" };
std::deque<int32_t> recentLog;
string chipState;

enum class MemoryType
{
	Vram = 0,
	PaletteRam = 1,
	SpriteRam = 2,
	FullState = 3,
};

struct EmulationState
{
	int32_t halfcycle;
	int32_t hpos;
	int32_t vpos;
	int32_t vramaddr_v;
	int32_t vramaddr_t;
	int32_t vbl_flag;
	int32_t spr_overflow;
	int32_t spr0_hit;

	int32_t recentLog[10000];
};

extern "C" 
{
	DllExport void initEmulator()
	{
		loadDataDefinitions();
		initDataStructures();

		startLogging();
	}

	DllExport void release()
	{
		stopLogging();
	}

	DllExport void reset(char* state)
	{
		recentLog.clear();
		initChip(state);		
	}

	DllExport const char* getSaveState()
	{
		chipState = getStateString();
		return chipState.c_str();
	}

	DllExport int32_t getMemoryState(MemoryType memoryType, uint8_t *buffer)
	{
		switch(memoryType) {
			case MemoryType::Vram: 
				memcpy(buffer, memory, sizeof(memory)); 
				return sizeof(memory);

			case MemoryType::PaletteRam:
				for(int i = 0; i < 0x20; i++) {
					buffer[i] = palette_read(i);
				}
				return 0x20;

			case MemoryType::SpriteRam:
				for(int i = 0; i < 0x100; i++) {
					buffer[i] = sprite_read(i);
				}
				return 0x100;

			case MemoryType::FullState:
				string state = getSaveState();
				memcpy(buffer, state.c_str(), state.size());
				buffer += state.size();
				buffer += getMemoryState(MemoryType::Vram, buffer);
				buffer += getMemoryState(MemoryType::PaletteRam, buffer);
				buffer += getMemoryState(MemoryType::SpriteRam, buffer);
				return (int32_t)(state.size() + sizeof(memory) + 0x20 + 0x100);
		}

		return 0;
	}

	DllExport void setMemoryState(MemoryType memoryType, uint8_t *buffer)
	{
		switch(memoryType) {
			case MemoryType::Vram: memcpy(memory, buffer, sizeof(memory)); break;

			case MemoryType::PaletteRam:
				for(int i = 0; i < 0x20; i++) {
					palette_write(i, buffer[i]);
				}
				break;

			case MemoryType::SpriteRam:
				for(int i = 0; i < 0x100; i++) {
					sprite_write(i, buffer[i]);
				}
				break;

			case MemoryType::FullState:
				size_t stateSize = getStateString().size();
				char* state = new char[stateSize + 1];
				memcpy(state, buffer, stateSize);
				state[stateSize] = 0;
				initChip(state);
				buffer += stateSize;
				setMemoryState(MemoryType::Vram, buffer);
				buffer += sizeof(memory);
				setMemoryState(MemoryType::PaletteRam, buffer);
				buffer += 0x20;
				setMemoryState(MemoryType::SpriteRam, buffer);
				break;
		}
	}

	DllExport void addTrace(char* nodeName)
	{
		logVars.push_back(nodeName);
	}

	DllExport void clearTrace()
	{
		logVars = {};
	}

	DllExport void getState(EmulationState *state)
	{
		state->halfcycle = readBits("cycle");
		state->hpos = readBits("hpos");
		state->vpos = readBits("vpos");
		state->vramaddr_v = readBits("vramaddr_v");
		state->vramaddr_t = readBits("vramaddr_t");
		state->vbl_flag = readBits("vbl_flag");
		state->spr_overflow = readBits("spr_overflow");
		state->spr0_hit = readBits("spr0_hit");

		int i;
		int k = 0;
		for(i = (int)(recentLog.size() - logVars.size()); i >= 0; i -= (int)logVars.size()) {
			for(size_t j = 0; j < logVars.size(); j++) {
				state->recentLog[k] = recentLog[i+j];
				k++;
			}
		}
		if(k < 10000) {
			state->recentLog[k] = -1;
		} else {
			state->recentLog[9999] = -1;
		}
	}

	DllExport void step(uint32_t halfCycleCount)
	{
		vector<int> logBuffer;
		for(uint32_t i = 0; i < halfCycleCount; i++) {
			step();

			for(size_t j = 0; j < logVars.size(); j++) {
				int value = readBits(logVars[j], 0);
				logBuffer.push_back(value);

				recentLog.push_back(value);
				if(recentLog.size() > 10000) {
					recentLog.pop_front();
				}
			}

			if(i % 10000 == 0) {
				flushLog(logVars, logBuffer);
				logBuffer.clear();
			}
		}
		flushLog(logVars, logBuffer);
	}
}