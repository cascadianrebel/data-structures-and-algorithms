using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Animal
    {
        public string Pref { get; set; }
        public Animal Next { get; set; }

        public Animal (string pref)
        {
            Pref = pref;
        }
    }
}
