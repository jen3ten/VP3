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

        public List<Pet> myPets = new List<Pet>();

        public void AddPetList(Pet firstPet)
        {
            Console.WriteLine("Added to list!");
            myPets.Add(firstPet);
        }

        public void PetList()
        {
            foreach (Pet element in myPets)
            {
                Console.WriteLine($"{element.Name} {element.Species}");
            }
        }

        public void PlayAll()
        {
            foreach (Pet element in myPets)
            {
                element.PlayPet();
            }
        }

        public void GetStatus()
        {
                Console.WriteLine("Name  |  Hunger  |  Boredom  |  Health  |");
                Console.WriteLine(" -----|----------|-----------|----------|");
            foreach (Pet element in myPets)
            {
                Console.WriteLine($"{element.Name}  |    {element.Hunger}     |    {element.Boredom}      |    {element.Health}    |");
            }
        }

        public void FeedAll()
        {
            foreach (Pet element in myPets)
            {
                element.FeedPet();
            }
        }

        public void CareAll()
        {
            foreach (Pet element in myPets)
            {
                element.PetCare();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Name    |   Species     |");
            Console.WriteLine("--------|---------------|");
            foreach(Pet element in myPets)
            {
                Console.WriteLine($"{ element.Name}    |   { element.Species}    |");
            }
        }

    }
}

