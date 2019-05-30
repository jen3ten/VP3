using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Energy { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Energy = 9;
            Boredom = 2;
            Health = 10;
        }
        Shelter shelter = new Shelter("Shelter");
        protected string petSpecies;
        protected string petName;

        public virtual void CreatePet()
        {
            Console.WriteLine("Please choose which pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
            petSpecies = Console.ReadLine();
            Console.WriteLine("Please give a name to your " + petSpecies);
            petName = Console.ReadLine();

        }

        public virtual void FeedPet()
        {
            Energy = Energy - 1;
            Boredom++;
        }

        public virtual void PlayPet()
        {
            Boredom -= 2;
            Energy += 3;
            int injuryChance = new Random().Next(1, 101);
            if (injuryChance <= 100)
            {
                Health -= 5;
                Console.WriteLine("Oh No! You're pet got hurt while playing. You better take them to the vet!");
            }
        }

        public virtual void PetCare()
        {
            Health++;
            Boredom++;
            Energy++;
        }

        
        public virtual void GetInfo()
        {
            Console.WriteLine("Your " + Species + " is named " + Name);
        }


       
            
      
        
        
    }
}
