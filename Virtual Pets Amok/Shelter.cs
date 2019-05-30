using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    public class Shelter
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
                Console.WriteLine("You just played with all of your Pets!");
            }
        }

        public void GetStatus()
        {
                Console.WriteLine("Name  |  Hunger  |  Boredom  |  Health  |");
                Console.WriteLine(" -----|----------|-----------|----------|");
            foreach (Pet element in myPets)
            {
                Console.WriteLine($"{element.Name}  |    {element.Energy}     |    {element.Boredom}      |    {element.Health}    |");
            }
        }

        public void FeedAll()
        {
            foreach (Pet element in myPets)
            {
                element.FeedPet();
                Console.WriteLine("You just fed all the Pets in your shelter");
            }
        }

        public void CareAll()
        {
            foreach (Pet element in myPets)
            {
                element.PetCare();
                Console.WriteLine("You just took all your Pets to the veteranarian");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Name       |   Species     |");
            Console.WriteLine("-----------|---------------|");
            int i = 1;
            foreach(Pet element in myPets)
            {
                Console.WriteLine($" {i++} { element.Name}    |   { element.Species}    |");
            }
        }

        public void SingleFeed()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myPets[Convert.ToInt32(Console.ReadLine())-1];

            choicePet.FeedPet();
            Console.WriteLine($"You just fed {choicePet.Name}!");
        }

    }
}

