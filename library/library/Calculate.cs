using System;

namespace library
{
    public class Calculate
    {
        public int Addition(int a , int b)
        {
            return a + b;
        }

        public int Substraction(int a, int b)
        {
            return a - b;
        }

        public double Sinus(double a)
        {
            return Math.Sin(a);
        }

        public double Cosinus(double a)
        {
            return Math.Cos(a);
        }

        public double Reverse(double a)
        {
            return 1 / a;
        }

        public double Exponenta(double a)
        {
            return Math.Exp(a);
        }
    }
}
