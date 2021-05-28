using System;
using System.Runtime.InteropServices;

namespace WorkWithLib
{
    class Program
    {
        [DllImport("../../../../Dll(lab).dll", CallingConvention = CallingConvention.StdCall)]
        static extern int dec2bin(int x);
        [DllImport("../../../../Dll(lab).dll", CallingConvention = CallingConvention.StdCall)]
        static extern double inverse(int x);
        [DllImport("../../../../Dll(lab).dll", CallingConvention = CallingConvention.StdCall)]
        static extern int dec2oct(int x);
        static void Main(string[] args)
        {
            
            Console.WriteLine(inverse(10));
            Console.WriteLine(dec2bin(10));
            Console.WriteLine(dec2oct(10));
        }
    }
}
