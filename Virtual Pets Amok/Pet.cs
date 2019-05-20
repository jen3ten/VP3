using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Health { get; set; }
        public string Happiness { get; set; }

        public Pet(string name, string species, string health, string happiness)
        {
            Name = name;
            Species = species;
            Health = health;
            Happiness = happiness;
       
        }
        

    }


}
