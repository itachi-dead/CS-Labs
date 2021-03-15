using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace lab3
{
    class ALU
    {
        public static int counter = 0;
        public ALU()
        {
            counter++;
            Id = counter;
        }
        public ALU(string name)
        {

        }
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Brand
        {
            get;
            set;
        }

        public void Print()
        {     
                Console.WriteLine(Id);
                Console.WriteLine($"\t{Name}");
                Console.WriteLine($"\t{Brand}");
        }
        public void Print(string IdName)
        {
            Console.WriteLine($"{Id} - {Name}");
        }

        public string FindAndRemove(string Id, List<ALU>a)
        {
            bool found = false;
            foreach(ALU i in a)
            {
                    if (i.Id.ToString().Equals(Id))
                    {
                        a.Remove(i);
                        found = true;
                        Change(i, a);
                        break;
                    }
            }
            return found? "Succesfully removed" :"there is no such an Id";
        }
        public void Change(ALU i ,List<ALU>a)
        {
            for (int j = i.Id - 1; j < a.Count; j++)
            {
                a[j].Id--;
            }
        }
    }
}
