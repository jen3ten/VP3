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

        Pet myPet = new Pet("", "");
        List<Pet> myPets = new List<Pet>();

        public void AddPetList()
        {
            Console.WriteLine("Added to list!");
            myPets.Add($"{myPet.Name}" $"{myPet.Species}");

        }


        public void PetList()
        {
            List<Pet> myPets = new List<Pet>() { };
            
            foreach(Pet element in myPets)
            {
                Console.WriteLine($"{element.Name} {element.Species}");
            }

        }
            
        }
    }

