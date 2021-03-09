using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_task3
{
    class NumberCounter
    {
        public List<int> counter { get; set; }

        public List<char> defaultNumbers { get; set; }

        public void Add()
        {
            counter = new List<int>();
            defaultNumbers = new List<char>();
            for (int i = 0; i < 10; i++)
            {
                counter.Add(0);
            }
            for (int i = 0; i < 10; i++)
            {
                defaultNumbers.Add((char)(i + 48));
            }
        }
        public void Find(string dateTime)
        {
            foreach (char i in dateTime)
            {
                if (defaultNumbers.Contains(i))
                {
                    counter[i - 48]++;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} - {counter[i]} ");
            }
        }
    }
}


