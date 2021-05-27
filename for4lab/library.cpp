#include "library.h"
#include <math.h>
#include "pch.h"
using namespace std;
const double PI = 3.14;

extern "C" __declspec(dllexport) int __stdcall abs(int x)
{
    if (x < 0) return x * (-1);
    return x;
}
extern "C" __declspec(dllexport)int sum(int x, int y)
{
    return x + y;
}
extern "C" __declspec(dllexport)int sub(int x, int y)
{
    return x - y;
}

extern "C" __declspec(dllexport)unsigned factorial(int x)
{
    unsigned f = 1;
    for (int i = 1; i <= x; i++)
    {
        f *= i;
    }
    return f;
}
extern "C" __declspec(dllexport) double __stdcall sin(double x)
{
    int a = x;
    double result;
    if (x > PI)
    {
        while (x > PI)
        {
            x -= 2 * PI;
        }
    }
    else if (x < 0)
    {
        while (x < 0)
        {
            x += 2 * PI;
        }
    }
    if (x >= 0 && x <= PI)
    {
        result = (16 * x * (PI - x)) / (5 * PI * PI - 4 * x * (PI - x));
    }
    else
    {
        x = fabs(x);
        result = -(16 * x * (PI - x)) / (5 * PI * PI - 4 * x * (PI - x));
    }
    return result;
}

