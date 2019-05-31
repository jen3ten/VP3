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

        // Added to handle type of Pet instead of adding derived classes
        public int TypeOfPet { get; set; }

        public Pet(string name, string species, int type)
        {
            Name = name;
            Species = species;
            TypeOfPet = type;
            Energy = 45;
            Boredom = 30;
            Health = 85;
        }

        Shelter shelter = new Shelter("Shelter");
        //RoboticShelter roboShelter = new RoboticShelter("RoboShelter");

        protected string petSpecies;
        protected string petName;

        public virtual void CreatePet(int type)
        {
            if(type == 1)
            {
                Console.WriteLine("Please choose which Pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
            }
            else
            {
                Console.WriteLine("Please choose which Robotic Pet you would like to add to your shelter: Dog, Dinosaur, Racoon, or Hedgehog");
            }
            petSpecies = Console.ReadLine();
            Console.WriteLine("Please give a name to your " + petSpecies);
            petName = Console.ReadLine();
            this.Name = petName;
            this.Species = petSpecies;
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
            if (injuryChance <= 50)
            {
                Health -= 25;
                Console.WriteLine($"Oh No! {Name} got hurt while playing. You better take them to get cared for!");
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
