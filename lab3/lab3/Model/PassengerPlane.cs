using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class PassengerPlane : Plane
    {
        public PassengerPlane(string name)
        {
            counter++;
            Id = counter;
            Type = "Passenger";
            this.Name = name;
        }
    }
}
