using System.Runtime.InteropServices;
using System;


namespace lab4_task2
{
    class Program
    {
        [DllImport("libuntitled1.dll")]
        public static extern int sum(int x, int y);

        [DllImport("libuntitled1.dll")]
        public static extern int sub(int x, int y);

        [DllImport("libuntitled1.dll")]
        public static extern double sin(double x);

        [DllImport("libuntitled1.dll")]
        public static extern double cos(double x);

        [DllImport("libuntitled1.dll")]
        public static extern double exp(double x);

        [DllImport("libuntitled1.dll")]
        public static extern uint factorial(int x);

        public static void Main(string[] args)
        {
            Console.WriteLine($"Sum of 15 and 29 is {sum(15, 29)}\n");
            Console.WriteLine($"Subtraction of 20 and 150 is {sub(20, 150)}\n");
            Console.WriteLine($"Sin(10) is {sin(10)} and Cos(29) is {cos(29)}\n");
            Console.WriteLine($"Factorial 4 is {factorial(4)}\n");
            Console.WriteLine($"Exp(3) is {exp(3)}\n");
        }
    }
}