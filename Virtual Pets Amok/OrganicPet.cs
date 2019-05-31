using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    //public class OrganicPet : Pet
    //{
        // Was not used
        // OrganicPet organicPet;

        //public OrganicPet(string name, string species) : base(name, species)
        //{
        //}


        //public override void CreatePet()
        //{
            // The only unique aspect of this class is the type of pet.  Instead
            // of creating a separate class for robotic, this piece of information
            // could have been handled with a property called "PetType" in the Pet
            // class.  This misses the point of the exercise, which was to have 
            // different versions of a pet, with differing properties and method
            // execution

            //Console.WriteLine("Please choose which Pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
            //base.CreatePet();
            // These could be set in base.CreatePet()
            //this.Name = petName;
            //this.Species = petSpecies;
            //organicPet = new OrganicPet(petName, petSpecies);
        //}

        // These methods are just calling the method of the base class, 
        // therefore this derived class with override methods is unnecessary
        //public override void FeedPet()
        //{
        //    base.FeedPet();
            
        //}

        //public override void PlayPet()
        //{
        //    base.PlayPet();
            
        //}

        //public override void PetCare()
        //{
        //    base.PetCare();
            
        //}

        //public override void GetInfo()
        //{
        //    base.GetInfo();
        //    Console.WriteLine("Your " + Species + " is named " + Name);
        //}
    //}
}
