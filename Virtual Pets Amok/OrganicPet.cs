using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    public class OrganicPet : Pet
    {
        OrganicPet organicPet;

        public OrganicPet(string name, string species) : base(name, species)
        {
        }


        public override void CreatePet()
        {
            Console.WriteLine("Please choose which Pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
            base.CreatePet();
            this.Name = petName;
            this.Species = petSpecies;
            //organicPet = new OrganicPet(petName, petSpecies);
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
            Console.WriteLine("You just took your Pet to the Veteranarian!");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Your " + Species + " is named " + Name);
        }
    }
}
