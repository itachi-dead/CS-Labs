using System;
using System.Text;

namespace lab2_task2test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alphabet = "qwertyuiopasdfghjklzxcvbnm";
            Random rnd = new Random();
            RandomString randomString = new RandomString(Alphabet);
            randomString.Print();

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    randomString.Print();
                }
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
}
