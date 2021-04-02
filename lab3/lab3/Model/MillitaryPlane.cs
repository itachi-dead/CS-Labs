using lab3.Model;
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
        }
    
        Bomb bomb = new Bomb();
        public override void Fly(string country)
        {
            Console.WriteLine("Do u want to start bombing this country? 1)yes 2)no:");
            string answer = Console.ReadLine();
            if (answer.Equals("1"))
            {
                
               string mark = "0";
               for(int i = 0;i < 5;i++)
                {
                    Console.WriteLine($"{i+1} {bomb[i]}");
                }
                Console.WriteLine("Choose witch bomb u want to use\n");
                mark = Console.ReadLine();

                Validator validate = new Validator();
                if (validate.IfBombMarkCorrect(mark))
                {
                    base.Fly(country);
                    Console.WriteLine($"{Name} destroyed country {country} with {bomb[Int32.Parse(mark) - 1]}\n");
                }
                else
                {
                    Console.WriteLine("No such a bomb, was choosed not to bomb the country\n");
                }
            }
            else
            {
                base.Fly(country);
            }
        }
    }
}
