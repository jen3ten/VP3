using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    class Shelter
    {
        public string ShelterName { get; set; }

        public Shelter(string shelterName)
        {
            ShelterName = shelterName;
        }

        List<Pet> myPets = new List<Pet>();

        public void AddPetList(Pet firstPet)
        {
            Console.WriteLine("Added to list!");
            myPets.Add(firstPet);
        }


        public void PetList()
        {
            
            foreach(Pet element in myPets)
            {
                Console.WriteLine($"{element.Name} {element.Species}");
            }

        }
            
    }
}

