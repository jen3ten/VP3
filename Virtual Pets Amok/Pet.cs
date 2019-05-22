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

        public void CreatePet()
        {
            Console.WriteLine("Please choose which pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
            string petSpecies = Console.ReadLine();
            Console.WriteLine("Please give a name to your " + petSpecies);
            string petName = Console.ReadLine();
            //Pet firstPet = new Pet(petName, petSpecies);
            Name = petName;
            Species = petSpecies;
        }

        public void FeedPet()
        {
            Console.WriteLine("You just fed your pet!");
            Hunger = Hunger - 3;
            Boredom++;
        }

        public void PlayPet()
        {
            Console.WriteLine("You just played with your pet!");
            Boredom -= 2;
            Hunger += 3;
            int injuryChance = new Random().Next(1, 101);
            if (injuryChance <= 100)
            {
                Health -= 5;
            }
        }

        public void VisitVet()
        {
            Console.WriteLine("You want to take your pet in for a check up.");
            Health++;
            Boredom++;
            Hunger++;
        }

        
        public void GetInfo()
        {
            Console.WriteLine("Your " + Species + "is named " + Name);
            
        }

        public void GetStatus()
        {
            Console.WriteLine("Your pet's hunger is " + Hunger);
            Console.WriteLine("Your pet's boredom level is " + Boredom);
            Console.WriteLine("Your pet's health level is " + Health);
        }
    }



}
