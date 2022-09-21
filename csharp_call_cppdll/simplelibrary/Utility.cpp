#include "pch.h"
#include <math.h>

extern "C" _declspec(dllexport) int Add(int x, int y) {
	return x + y;
}

extern "C" _declspec(dllexport) void Pow(int* x, double y) {
	*x = pow(*x, y);
}