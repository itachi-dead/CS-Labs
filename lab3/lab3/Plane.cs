using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Plane
    {
        static protected int counter = 0;
        public Plane()
        {
            Type = "";
            Name = "";
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        virtual public void Fly(string country)
        {
            Console.WriteLine();
            Console.WriteLine("BzBzbzzzbbzzzzz......");
            Console.WriteLine("..........BzBzbzzzbbzzzzz......");
            Console.WriteLine("..........BzBzbzzzbbzzzzzzBzbzzzBzbzz");
            Console.WriteLine($"Plane {Id} - {Name} arrived at {country}");
        }
        public void PrintType()
        {
            Console.WriteLine($"{Id} - {Name} - {Type}");
        }
        public void Print()
        {
            Console.WriteLine($"{Id} - {Name}");
        }
    }
}
