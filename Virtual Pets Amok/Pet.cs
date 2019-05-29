using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    public class Pet
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
        Shelter shelter = new Shelter("Shelter");
        Pet firstPet;
        public void CreatePet()
        {
            Console.WriteLine("Please choose which pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
            string petSpecies = Console.ReadLine();
            Console.WriteLine("Please give a name to your " + petSpecies);
            string petName = Console.ReadLine();
            firstPet = new Pet(petName, petSpecies);
            Name = petName;
            Species = petSpecies;

        }

        public virtual void FeedPet()
        {
            Hunger = Hunger - 3;
            Boredom++;
        }

        public void PlayPet()
        {
            Boredom -= 2;
            Hunger += 3;
            int injuryChance = new Random().Next(1, 101);
            if (injuryChance <= 100)
            {
                Health -= 5;
                Console.WriteLine("Oh No! You're pet got hurt while playing. You better take them to the vet!");
            }
        }

        public void PetCare()
        {
            Health++;
            Boredom++;
            Hunger++;
        }

        
        public void GetInfo()
        {
            Console.WriteLine("Your " + Species + " is named " + Name);
        }


       
            
      
        
        
    }
}
