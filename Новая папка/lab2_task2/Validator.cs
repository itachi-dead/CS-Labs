using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_task2
{
    class Validator
    {
        public bool isValid(string a , string b)
        {
            foreach(char i in a)
            {
                if(i < '0' || i > '9')
                {
                    return false;
                }
            }

            foreach (char i in b)
            {
                if (i < '0' || i > '9')
                {
                    return false;
                }
            }

            if(Int64.Parse(a) > Int64.Parse(b))
            {
                return false;
            }
            return true;
        }
    }
}
