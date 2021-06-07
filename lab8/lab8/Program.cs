using lab6.Model;
using lab8.NotificationsAndLogs;
using System;
using System.Collections.Generic;

namespace lab3
{
    class Program
    {
        delegate void ChoiceWhatToDo(string key, Validator check, List<Plane> planes);
        static void Main(string[] args)
        {
            bool stop = false;
            List<Plane> planes = new List<Plane>();
            string n = "";
            Validator check = new Validator();
            ChoiceWhatToDo choice = FirstChoice;
            choice += SecondChoice;
            choice += ThirdChoice;
            choice += ForthChoice;
            choice += ExitChoice;
            while (!stop)
            {
                Console.WriteLine("Enter 1 if u want to add plane");
                Console.WriteLine("Enter 2 if u want to see short list of planes");
                Console.WriteLine("Enter 3 if u want to see full list of planes");
                Console.WriteLine("Enter 4 if u want to fly to any country");
                Console.WriteLine("Enter 0 if u want to exit");
                n = Console.ReadLine();
                Notify.NoticeMeSenpai("123");
                choice(n, check, planes);
                Console.WriteLine();
            }

            static void FirstChoice(string key, Validator check , List<Plane> planes)
            {
                if (key == "1")
                {
                    Console.WriteLine("What plane do u want ot add 1)cargo or 2)passenger: ");
                    string temp = Console.ReadLine();

                    while (!check.IfCorrectChoice(temp))
                    {

                        temp = Console.ReadLine();
                    }//check

                    Console.WriteLine("Enter name of the plane:");
                    string name = Console.ReadLine();

                    if (temp.Equals("1"))
                    {
                        Console.WriteLine("Do u want to create Millitary plane 1)yes 2)no:");
                        string millitary = Console.ReadLine();

                        while (!check.IfCorrectChoice(millitary))
                        {
                            Console.WriteLine("No correct option, try again");
                            millitary = Console.ReadLine();
                        }//check

                        if (millitary.Equals("1"))//Milliytary
                        {
                            MillitaryPlane a = new MillitaryPlane(name, 0);
                            planes.Add(a);
                            Notify.NoticeMeSenpai("Millitary");

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
                            Notify.NoticeMeSenpai("Cargo");
                        }
                    }
                    else
                    {
                        PassengerPlane a = new PassengerPlane(name);
                        planes.Add(a);
                        Notify.NoticeMeSenpai("Passenger");

                    }
                }
            }
            static void SecondChoice(string key, Validator check, List<Plane> planes)
            {
                if(key == "2")
                foreach (IPrint plane in planes)
                {
                    plane.Print();
                }
            }
            static void ThirdChoice(string key, Validator check, List<Plane> planes)
            {
                if(key == "3")
                foreach (IPrint plane in planes)
                {
                    plane.PrintType();
                }
            }
            static void ForthChoice(string key, Validator check, List<Plane> planes)
            {
                if (key == "4")
                {
                    foreach (IPrint plane in planes)
                    {
                        plane.Print();
                    }

                    Console.WriteLine("Enter id of plane u want to fly:");
                    string Id = Console.ReadLine();
                    if (!check.IfIdCorrect(Id, planes))
                    {
                        Console.WriteLine("No such an Id");
                        return;
                    }//check with break

                    Console.WriteLine("Enter country u want to fly:");
                    string country = Console.ReadLine();

                    IPrint IPlane = planes[Int32.Parse(Id) - 1];
                    IPlane.Fly(country);
                }
            }
            static void ExitChoice(string key, Validator check, List<Plane> planes) { if (key == "0") Environment.Exit(0); }
        }
    }
}
