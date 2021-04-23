#ifndef LIBRARY_H
#define LIBRARY_H

extern "C" __declspec(dllexport) __fastcall int sum(int a, int b);
extern "C" __declspec(dllexport) __fastcall int sub(int a, int b);
extern "C" __declspec(dllexport) __cdecl unsigned factorial(int a);
extern "C" __declspec(dllexport) double __stdcall sin(double x);
extern "C" __declspec(dllexport) double __stdcall cos(double x);
extern "C" __declspec(dllexport) double __stdcall exp(double x);




#endif //UNTITLED1_LIBRARY_H
