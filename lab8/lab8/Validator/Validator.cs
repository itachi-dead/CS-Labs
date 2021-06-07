using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Validator
    {
        public bool IfCorrectChoice(string check)
        {
            if (!check.Equals("1") && !check.Equals("2"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IfIdCorrect(string Id, List<Plane> planes)
        {
            foreach(Plane plane in planes)
            {
                if(plane.Id.ToString().Equals(Id))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IfBombMarkCorrect(string mark)
        {
            for(int i =1; i <= 5; i++)
            {
                if(mark.Equals(i.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
