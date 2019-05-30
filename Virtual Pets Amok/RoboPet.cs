using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    public class RoboPet : Pet 
    {

        RoboPet roboPet;

        public RoboPet(string name, string species) : base(name, species)
        {
        }

        public override void CreatePet()
        {
            Console.WriteLine("Please choose which Robotic Pet you would like to add to your shelter: Dog, Dinosaur, Racoon, or Hedgehog");
            base.CreatePet();
                this.Name = petName;
                this.Species = petSpecies;
        }

        public override void FeedPet()
        {
            base.FeedPet();
            
        }

        public override void PlayPet()
        {
            base.PlayPet();
            Console.WriteLine("You just played with your Pet!");
        }

        public override void PetCare()
        {
            base.PetCare();
            Console.WriteLine("You just took your Pet in for maintenance!");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Your " + Species + " is named " + Name);
        }
    }
}
