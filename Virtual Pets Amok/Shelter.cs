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
            Console.WriteLine("\nAdded to list!");
            myPets.Add(firstPet);
        }

        public virtual void RemovePetList(Pet firstPet)
        {
            GetInfo();
            Console.WriteLine("Please select a pet to remove from the shelter.");
            Pet choicePet = myPets[Convert.ToInt32(Console.ReadLine()) - 1];

            Console.WriteLine($"\n{choicePet.Name} was removed from the shelter!");
            
            myPets.Remove(choicePet);
        }

        public void PetList()
        {
                Console.WriteLine("Organic Shelter");
                Console.WriteLine("\nName        |  Species            |");
                Console.WriteLine("------------|---------------------|");
            int i = 1;
            foreach (Pet element in myPets)
            {
                Console.WriteLine($"{i++}. {element.Name}     |    {element.Species}");
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
            int i = 1;
            foreach (Pet element in myPets)
            {
                Console.WriteLine($"{i++}. {element.Name}  |    {element.Energy}     |    {element.Boredom}      |    {element.Health}    |");
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
                Console.WriteLine($" {i++}. { element.Name}    |   { element.Species}    |");
            }
        }

        public virtual void SingleFeed()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myPets[Convert.ToInt32(Console.ReadLine())-1];

            choicePet.FeedPet();
            Console.WriteLine($"You just fed {choicePet.Name}!");
        }

        public virtual void SinglePlay()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myPets[Convert.ToInt32(Console.ReadLine()) - 1];

            choicePet.PlayPet();
            Console.WriteLine($"You just played with {choicePet.Name}!");
        }

        public virtual void SingleCare()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myPets[Convert.ToInt32(Console.ReadLine()) - 1];

            choicePet.PetCare();
            Console.WriteLine($"You just took {choicePet.Name} to the vet!");
        }

        public void TimeToll()
        {
            foreach (Pet element in myPets)
            {
                element.MenuTime();

            }
        }
    }
}

