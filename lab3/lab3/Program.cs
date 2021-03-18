using System;
using System.Collections.Generic;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            List<Plane> planes = new List<Plane>();
            string n = "";
            while (!stop)
            {
                n = Console.ReadLine();
                Console.WriteLine();

                switch (n) {
                    case "1":
                        Console.WriteLine("What plane do u want ot add 1)cargo or 2)passenger: ");
                        string temp = Console.ReadLine();

                        Console.WriteLine("Enter name of th plane:");
                        string name = Console.ReadLine();

                        if(temp.Equals("1"))
                        {
                            Console.WriteLine("Do u want to create Millitary plane 1)yes 2)no:");
                            string millitary = Console.ReadLine();

                            if (millitary.Equals("1"))
                            {
                                MillitaryPlane a = new MillitaryPlane(name);
                                planes.Add(a);
                            }
                            else
                            {
                                CargoPlane a = new CargoPlane(name);
                                planes.Add(a);
                            }
                        }
                        else
                        {
                            PassengerPlane a = new PassengerPlane(name);
                            planes.Add(a);
                        }
                        break;

                    case "2":
                        foreach(Plane plane in planes)
                        {
                            plane.Print();
                        }
                        break;

                    case "3":
                        foreach (Plane plane in planes)
                        {
                            plane.PrintType();
                        }
                        break;
                    case "4":
                       foreach(Plane plane in planes)
                        {
                            plane.Print();
                        }
                        Console.WriteLine("Enter id of plane u want to fly:");
                        string Id = Console.ReadLine();
                        Console.WriteLine("Enter country u want to fly:");
                        string country = Console.ReadLine();
                        planes[Int32.Parse(Id)-1].Fly(country);
                        break;
                }
                Console.WriteLine();

               
            }
        }
    }
}
