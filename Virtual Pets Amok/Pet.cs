using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
      

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
       
        }
        
        public void GetInfo()
        {
            Console.WriteLine("Your " + Species + "is named " + Name);
            
        }
    }


}
