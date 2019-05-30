using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    public class RoboPet : Pet 
    {

        RoboPet roboPet;

        public string Name { get; set; }
        public string Species { get; set; }
        public RoboPet(string name, string species) : base("", "")
        {
        }

        public void CreateRoboPet()
        {
           
                Console.WriteLine("Please choose which pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
                string roboSpecies = Console.ReadLine();
                Console.WriteLine("Please give a name to your " + roboSpecies);
                string roboName = Console.ReadLine();
                roboPet = new RoboPet(roboName, roboSpecies);
                Name = roboName;
                Species = roboSpecies;

            }

        public override void FeedPet()
        {
            base.FeedPet();
            Energy -= 1; 
            Console.WriteLine($"You just oiled your Robopet!");

        }
    }
}
