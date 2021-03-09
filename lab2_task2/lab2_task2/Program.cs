using System;

namespace lab2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator check = new Validator();

            string a, b;
            Console.WriteLine("Enter a gap [a,b]");

            Console.Write("Enter a:");
            a = Console.ReadLine();

            Console.Write("Enter b:");
            b = Console.ReadLine();

            if(!check.isValid(a, b))
            {
                Console.WriteLine("Entered gap in not correct");
            }
            else
            {
                long gapA = Int64.Parse(a);
                long gapB = Int64.Parse(b);
                long power = 0;
                for(long i = gapA; i < gapB; i++)
                {
                    long j = i;
                    while(j >= 2) 
                    {
                        power += j / 2;
                        j /= 2;
                    }
                    
                }
                Console.WriteLine($"2^{power}");

            }
        }
    }
}
