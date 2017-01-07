# Visual NES
This is a C++/C# port of the Visual 2C02 and the Visual 2A03 by Quietust (http://www.qmtpro.com/~nes/chipimages/visual2c02/)  
It combines both simulators into a single simulation and allows the simulation to run NES roms (albeit at roughly 1/1000th of the speed of a real NES)  
The Visual 2C02/2A03 are adapted from the code of the Visual 6502 (http://www.visual6502.org/JSSim/index.html)  

This also adds a few feature (load/save states/memory, logging to disk).  It also simulates both the 2C02 and the 2A03 together much faster than the javascript versions (10-20x faster)  

A few features are still missing, but the goal is to port most of the originals' features in time.  

## Windows
Open the solution in VS2015 and run as Release/x64

## Linux
Run "make" and then "make run" (Requires Mono and a C++11 compiler - defaults to clang)
