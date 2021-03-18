using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class CargoPlane : Plane
    {
        public CargoPlane(string name)
        {
            counter++;
            Id = counter;
            Type = "Cargo";
            this.Name = name;
        }
    }
}
