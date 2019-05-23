using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    class Shelter
    {
        public string ShelterName { get; set; }

        public void AddPetList()
        {
            Console.WriteLine("Added to list!");
            
        }

        List<Pet> myPets = new List<Pet>() { } 
    }
}
