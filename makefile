CPPC=clang++
GCCOPTIONS=-fPIC -Wall --std=c++11 -O3

PLATFORM=x64
GCCOPTIONS += -m64
CCOPTIONS += -m64

OBJFOLDER=obj.$(PLATFORM)
SHAREDLIB=libCoreVisualNes.dll
RELEASEFOLDER=bin

COREOBJ=$(patsubst Core/%.cpp,Core/$(OBJFOLDER)/%.o,$(wildcard Core/*.cpp))

all: $(COREOBJ)
	mkdir -p Core/$(OBJFOLDER) && cd Core/$(OBJFOLDER) && $(CPPC) $(GCCOPTIONS) -Wl,-z,defs -Wno-parentheses -Wno-switch -shared -o $(SHAREDLIB) *.o -L . -pthread
	mkdir -p bin
	cp Core/*.txt $(RELEASEFOLDER)
	cp Core/$(OBJFOLDER)/$(SHAREDLIB) $(RELEASEFOLDER)/$(SHAREDLIB)	
	cd GUI && xbuild /property:Configuration="Release" /property:Platform="$(PLATFORM)" /property:PreBuildEvent="" /property:OutputPath="../bin/"

Core/$(OBJFOLDER)/%.o: Core/%.cpp
	mkdir -p Core/$(OBJFOLDER) && cd Core/$(OBJFOLDER) && $(CPPC) $(GCCOPTIONS) -Wno-parentheses -Wno-switch -c $(patsubst Core/%, ../%, $<)

run:
	MONO_LOG_LEVEL=debug mono $(RELEASEFOLDER)/VisualNes.exe

clean:
	rm Core/$(OBJFOLDER) -r -f
	rm $(RELEASEFOLDER) -r -f
