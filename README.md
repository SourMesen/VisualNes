# Visual2C02
This is a C++/C# port of the original Visual 2C02 by Quietust (http://www.qmtpro.com/~nes/chipimages/visual2c02/)  
The Visual 2C02 is an adaptation of the Visual 6502 (http://www.visual6502.org/JSSim/index.html)  

This adds a few feature (load/save states/memory, logging to disk), but most of all, simulates the 2C02 roughly 20-30x faster than the javascript version.

A few features are still missing, including the "visual" part :)

## Windows
Open the solution in VS2015 and run as Release/x64

## Linux
Run "make" and then "make run" (Requires Mono and a C++11 compiler - defaults to clang)
