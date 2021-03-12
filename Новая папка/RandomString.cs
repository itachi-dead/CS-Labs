using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_task2test
{
    class RandomString
    {
        public string Alphabet
        {
            get;
            set;
        }

        public RandomString(string Alphabet)
        {
            this.Alphabet = Alphabet;
        }

        public void Print()
        {
            Random rnd = new Random();
            int Position = 0;
            StringBuilder sb = new StringBuilder(3);
            for (int i = 0; i < 4; i++)
            {
                Position = rnd.Next(0, Alphabet.Length - 1);
                Console.WriteLine(Position);
                sb.Append(Alphabet[Position]);
            }
            Console.WriteLine(sb);
        }
    }
}
