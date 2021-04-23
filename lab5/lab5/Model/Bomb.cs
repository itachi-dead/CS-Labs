using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Model
{
    class Bomb
    {
        private string[] bombs = { "RDS-220 Hydrogen Bomb", "B41", "TX-21", "Mk-17", "Mk-24" };
        public string this[int i]
        {
            get
            {
                return bombs[i];
            }
            private set
            {
                bombs[i] = value;
            }
        }
    }
}
