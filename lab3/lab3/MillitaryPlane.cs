using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class MillitaryPlane : CargoPlane
    {
        public MillitaryPlane(string name):base(name)
        {
            Type = "Millitary";
            Bombs = 5;
        }
        public int Bombs
        {
            get;set;
        }
        public override void Fly(string country)
        {
            Console.WriteLine("Do u want to start bombing this country? 1)yes 2)no:");
            string answer = Console.ReadLine();
            if (answer.Equals("1"))
            {
               if(Bombs > 0)
                {
                    base.Fly(country);
                    Console.WriteLine($"{Name} destroyed country {country}");
                    Bombs--;
                }
                else
                {
                    Console.WriteLine("Not enough bombs, try other plane");
                }
            }
            else
            {
                base.Fly(country);
            }
        }
    }
}
