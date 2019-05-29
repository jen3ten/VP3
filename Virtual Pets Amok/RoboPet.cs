using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    public class RoboPet : Pet 
    {
        public int Oil { get; set; }

        public RoboPet(int oil) : base("", "")
        {
            Oil = Hunger; 
        }

        public override void FeedPet()
        {
            Console.WriteLine($"You just oiled your Robopet!");

        }
    }
}
