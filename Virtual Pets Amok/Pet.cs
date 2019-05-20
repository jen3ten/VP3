using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 0;
            Boredom = 2;
            Health = 10;

        }
        
        public void GetInfo()
        {
            Console.WriteLine("Your " + Species + "is named " + Name);
            
        }
    }


}
