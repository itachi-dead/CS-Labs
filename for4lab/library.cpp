#include "library.h"
#include <math.h>

const double PI = 3.14;


extern "C" __declspec(dllexport) __fastcall int sum(int x, int y)
{
    return x+y;
}

extern "C" __declspec(dllexport) __fastcall int sub(int x, int y)
{
    return x-y;
}

extern "C" __declspec(dllexport) __cdecl unsigned factorial(int x)
{
    unsigned f = 1;
    for(int i = 1; i<=x;i++)
    {
        f*=i;
    }
    return f;
}

extern "C" __declspec(dllexport) double __stdcall sin(double x)
{
   int a = x;
   double result;
   if(x>PI)
   {
       while(x>PI)
       {
           x-=2*PI;
       }
   }
   else if(x<0)
   {
       while(x<0)
       {
           x+=2*PI;
       }
   }
   if(x>=0 && x<=PI)
   {
      result = (16*x*(PI - x))/(5*PI*PI - 4*x*(PI-x));
   }
   else
   {
       x = fabs(x);
       result = -(16*x*(PI - x))/(5*PI*PI - 4*x*(PI-x));
   }
   return result;
}


extern "C" __declspec(dllexport) double __stdcall cos(double x)
{
    int a = x;
    double result;
    if(x>PI/2)
    {
        while(x>PI)
        {
            x-=2*PI;
        }
    }
    else if(x<-PI/2)
    {
        while(x<0)
        {
            x+=2*PI;
        }
    }
    if(x<PI/2 && x>-PI/2)
    {
        result = (PI*PI-4*x*x)/(PI*PI+x*x);
    }
    else
    {
        result = -((PI*PI-4*x*x)/(PI*PI+x*x));
    }
    return result;
}

extern "C" __declspec(dllexport) double __stdcall exp(double x)
{
    double result = pow(2, x/(log(2)));
    return result;
}


