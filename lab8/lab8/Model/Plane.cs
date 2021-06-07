using lab6.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Plane : IPrint
    {
        static public int counter = 0;
        public Plane()
        {
            Type = "";
            Name = "";
        }
        
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public virtual void Fly(string country)
        {
            Console.WriteLine();
            Console.WriteLine("BzBzbzzzbbzzzzz......");
            Console.WriteLine("..........BzBzbzzzbbzzzzz......");
            Console.WriteLine("..........BzBzbzzzbbzzzzzzBzbzzzBzbzz");
            Console.WriteLine($"Plane {Id} - {Name} arrived at {country}");
        }
        public virtual void PrintType()
        {
            Console.WriteLine($"{Id} - {Name} - {Type}");
        }
        public void Print()
        {
            Console.WriteLine($"{Id} - {Name}");
        }
    }
}
