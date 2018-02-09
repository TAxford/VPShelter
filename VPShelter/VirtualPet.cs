using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPet
    {
        //fields
        private string name;
        private int hunger;
        private int thirst;
        private int boredom;

        //Propeties
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }

        //Constrcutors
        public VirtualPet()
        {
            //default Constructor
        }

        public VirtualPet(string name, int hunger, int thirst, int boredom)
        {
            this.name = name;
            this.hunger = hunger;
            this.thirst = thirst;
            this.boredom = boredom;
        }

        //Methods      
        public virtual string PetName(string value)
        {
            name = value;
            return name;
        }

        public virtual int PetHunger(int value)
        {
            hunger = value;
            return hunger;
        }

        public virtual int PetThirst(int value)
        {
            thirst = value;
            return thirst;
        }

        public virtual int PetBoredom(int value)
        {
            boredom = value;
            return boredom;
        }








    }
}
