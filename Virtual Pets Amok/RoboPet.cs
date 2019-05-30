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
                base.CreatePet();
                this.Name = petName;
                this.Species = petSpecies;
        }

        public override void FeedPet()
        {
            base.FeedPet();
            Console.WriteLine($"You just oiled your Robopet!");
        }
    }
}
