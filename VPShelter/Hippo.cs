using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Hippo : VirtualPet
    {
        public Hippo()
        {
            //default constructor
        }

        public Hippo(string name, int hunger, int thirst, int boredom)
        {
            name = name;
            hunger = hunger;
            thirst = thirst;
            boredom = boredom;
        }

    }
}
