using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class CargoPlane : Plane
    {
        public CargoPlane(string name, int weight)
        {
            counter++;
            Id = counter;
            Type = "Cargo";
            this.Name = name;
            Capacity = weight;
        }

        public int Capacity { get; set; }

        public override void PrintType()
        {
            Console.WriteLine($"{Id} - {Name} - {Type} - weight:{Capacity}");
        }
    }
}
