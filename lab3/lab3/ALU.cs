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
            counter--;
        }

        //
        public override bool Equals(object obj)
        {
            return obj is ALU aLU &&
                   Id == aLU.Id &&
                   Name == aLU.Name &&
                   Brand == aLU.Brand;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Brand);
        }
        //override of ==
        public static bool operator ==(ALU c1, ALU c2)
        {
            return c1.Name.Equals(value: c2.Name);
        }
        public static bool operator !=(ALU c1, ALU c2)
        {
            return !c1.Name.Equals(value: c2.Name);
        }
        public static bool operator ==(ALU c1, string c2)
        {
            return c1.Name.Equals(c2);
        }
        public static bool operator !=(ALU c1, string c2)
        {
            return !c1.Name.Equals(c2);
        }

        /*public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ALU p = (ALU)obj;
                return p.Name.Equals(Name);
            }
        }*/
    }
}
