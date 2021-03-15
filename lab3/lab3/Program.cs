using System;
using System.Collections.Generic;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            List<ALU> proccsesors = new List<ALU>();
            string n = "";
            while (!stop)
            {
                Console.WriteLine("What do u want to do:");
                Console.WriteLine("Enter 1 to add proccesor");
                Console.WriteLine("Enter 2 to show all information");
                Console.WriteLine("Enter 3 to delete proccesor by Id:");
                Console.WriteLine("Enter 0 to end");

                n = Console.ReadLine();
                Console.WriteLine();

                switch (n) {
                    case "1":
                        ALU temp = new ALU();

                        Console.Write("Enter name of proccesor:");
                        temp.Name = Console.ReadLine();

                        Console.Write("Enter brand:");
                        temp.Brand = Console.ReadLine();

                        proccsesors.Add(temp);
                        break;
                    case "2":
                        foreach(ALU i in proccsesors)
                        {
                            i.Print();
                        }
                        break;
                    case "3":
                        foreach (ALU i in proccsesors)
                        {
                            i.Print("Id and Name");
                        }
                        Console.WriteLine("Enter id to delete");
                        string Id = "";
                        Id = Console.ReadLine();
                        ALU searching = new ALU("no counter");
                        if(searching.FindAndRemove(Id , proccsesors).Equals("Succesfully removed"))
                        {
                            Console.WriteLine("Succesfully removed");
                        }
                        else
                        {
                            Console.WriteLine("There is no such and Id");
                        }
                        break;
                    case "0":
                        stop = true;
                        break;
                }
                Console.WriteLine();

               
            }
        }
    }
}
