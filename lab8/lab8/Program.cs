using lab8.Exceptions;
using lab6.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab3
{
    class Program
    {

        private readonly List<Plane> planes;
        private bool stop;
        private readonly Validator validator;

        private delegate void HandleException(Exception e);
        private event HandleException NotifyException;

        private Program()
        {
            this.planes = new List<Plane>();
            this.stop = false;
            this.validator = new Validator();

            if (!File.Exists("Log.txt"))
            {
                File.Create("Log.txt");
            }

            NotifyException += delegate (Exception e)
            {
                string logData = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + " - Exception occured: " + e + "\n";
                File.AppendAllText("Log.txt", logData);
            };

            NotifyException += (Exception e) => Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + " - Exception occured: " + e + "\n");
        }
   

        private void Run()
        {
            

            while (!stop)
            {
                PrintMenu();
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddPlane();
                            break;

                        case "2":
                            PrintPlanes();
                            break;

                        case "3":
                            PrintTypes();
                            break;

                        case "4":

                            PrintPlanes();
                            FlyPlanes();
                            break;

                        case "0":
                            stop = true;
                            break;

                        default:
                            Console.WriteLine("No such choice");
                            break;
                    }
                    Console.WriteLine();

                } 
                catch (Exception e)
                {
                    NotifyException?.Invoke(e);
                }
            }
        }

        private void PrintTypes()
        {
            foreach (IPrint plane in planes)
            {
                plane.PrintType();
            }
        }

        private void PrintPlanes()
        {
            foreach (IPrint plane in planes)
            {
                plane.Print();
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Enter 1 if u want to add plane");
            Console.WriteLine("Enter 2 if u want to see short list of planes");
            Console.WriteLine("Enter 3 if u want to see full list of planes");
            Console.WriteLine("Enter 4 if u want to fly to any country");
        }


        private void AddPlane()
        {


            Console.WriteLine("What plane do u want ot add 1)cargo or 2)passenger: ");
            string temp = Console.ReadLine();

            while (!validator.IfCorrectChoice(temp))
            {

                temp = Console.ReadLine();
            }//check

            Console.WriteLine("Enter name of the plane:");
            string name = Console.ReadLine();

            if (temp.Equals("1"))
            {
                Console.WriteLine("Do u want to create Millitary plane 1)yes 2)no:");
                string millitary = Console.ReadLine();

                while (!validator.IfCorrectChoice(millitary))
                {
                    Console.WriteLine("No correct option, try again");
                    millitary = Console.ReadLine();
                }//check

                if (millitary.Equals("1"))//Milliytary
                {
                    MillitaryPlane a = new MillitaryPlane(name, 0);
                    planes.Add(a);
                }
                else//Cargo
                {
                    Console.WriteLine("Enter maximum weight that this plane can handle\n");
                    string stringWeight = Console.ReadLine();
                    int weight = 0;
                    while (!Int32.TryParse(stringWeight, out weight))
                    {
                        Console.WriteLine("Try again");
                        stringWeight = Console.ReadLine();
                    }
                    CargoPlane a = new CargoPlane(name, weight);
                    planes.Add(a);
                }
            }
            else
            {
                PassengerPlane a = new PassengerPlane(name);
                planes.Add(a);
            }
        }

        private void FlyPlanes()
        {

            Console.WriteLine("Enter id of plane u want to fly:");
            string Id = Console.ReadLine();
            if (!validator.IfIdCorrect(Id, planes))
            {
                Console.WriteLine("No such an Id");
                throw new PlaneNotFoundException("Plane with id " + Id + " not found");
     
            }//check with break

            Console.WriteLine("Enter country u want to fly:");
            string country = Console.ReadLine();

            IPrint IPlane = planes[Int32.Parse(Id) - 1];
            IPlane.Fly(country);
        }


        static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}
