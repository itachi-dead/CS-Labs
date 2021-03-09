using System;
using System.Collections.Generic;
using System.Globalization;

namespace lab2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;

            //getting dates
            string firstDateTime = datetime.ToString();
            string secondDateTime = datetime.ToString("G",
                  CultureInfo.CreateSpecificCulture("en-US"));

            //first date
            Console.WriteLine(firstDateTime);
            NumberCounter first = new NumberCounter();
            first.Add();
            first.Find(firstDateTime);
            first.Print();

            //second date
            Console.WriteLine(secondDateTime);
            NumberCounter second = new NumberCounter();
            second.Add();
            second.Find(secondDateTime);
            second.Print();
        }
    }
}
