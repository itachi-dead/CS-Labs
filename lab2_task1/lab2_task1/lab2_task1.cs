using System;
using System.Linq;
using System.Collections.Generic;
//Reverse words
namespace lab2_task1
{
    class lab2_task1
    {
        static void Main(string[] args)
        {
          Console
                 .ReadLine()
                 .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Reverse()
                 .ToList()
                 .ForEach(item => Console.Write(item + " "));
        }
    }
}
