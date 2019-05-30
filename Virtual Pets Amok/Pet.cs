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
            Energy = 45;
            Boredom = 30;
            Health = 85;
        }

        Shelter shelter = new Shelter("Shelter");
        RoboticShelter roboShelter = new RoboticShelter("RoboShelter");

        protected string petSpecies;
        protected string petName;

        public virtual void CreatePet()
        {
            petSpecies = Console.ReadLine();
            Console.WriteLine("Please give a name to your " + petSpecies);
            petName = Console.ReadLine();
        }

        public virtual void FeedPet()
        {
            Energy -= 11;
            Boredom += 7;
            Health += 4; 
        }

        public virtual void PlayPet()
        {
            Boredom -= 10;
            Energy += 7;
            int injuryChance = new Random().Next(1, 101);
            if (injuryChance <= 10)
            {
                Health -= 25;
                Console.WriteLine("Oh No! You're pet got hurt while playing. You better take them to get cared for!");
            }
        }

        public virtual void PetCare()
        {
            Health += 20;
            Boredom += 12;
            Energy += 10;
        }

        public void MenuTime()
        {
            Health--;
            Boredom -= 2;
            Energy += 2;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Your " + Species + " is named " + Name);
        }
        
    }
}
