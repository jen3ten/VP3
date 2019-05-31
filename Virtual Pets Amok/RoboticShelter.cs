using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    class RoboticShelter : Shelter
    {
        public int RoboticShelterName { get; set; }

        public RoboticShelter(string RoboticShelterName) : base("")

        {
            //RoboticShelterName = roboticShelterName;
        }

        public List<RoboPet> myRoboPets = new List<RoboPet>();
        
        public void AddRoboPetList(RoboPet roboPet)
        {
            Console.WriteLine("Added to list!");
            myRoboPets.Add(roboPet);
        }

        public void RemoveRoboPet(RoboPet roboPet)
        {
            GetInfo();
            Console.WriteLine("Please select a pet to remove from the shelter.");
            Pet choicePet = myRoboPets[Convert.ToInt32(Console.ReadLine()) - 1];

            Console.WriteLine($"\n{choicePet.Name} was removed from the shelter!");

            myPets.Remove(roboPet);
        }

        public void PetList()
        {
                Console.WriteLine("\n\nRobotic Shelter");
                Console.WriteLine("\nName        |  Species            |");
                Console.WriteLine("------------|---------------------|");
            foreach (Pet element in myRoboPets)
            {
                Console.WriteLine($"{element.Name}        |      {element.Species}");
            }
            Console.WriteLine("\n");
        }

        public void PlayAll()
        {
            foreach (Pet element in myRoboPets)
            {
                element.PlayPet();
                Console.WriteLine("You just played with all of your Pets!");
            }
        }

        public void GetStatus()
        {
            Console.WriteLine("Name  |  Hunger  |  Boredom  |  Health  |");
            Console.WriteLine(" -----|----------|-----------|----------|");
            foreach (Pet element in myRoboPets)
            {
                Console.WriteLine($"{element.Name}  |    {element.Energy}     |    {element.Boredom}      |    {element.Health}    |");
            }
        }

        public void FeedAll()
        {
            foreach (Pet element in myRoboPets)
            {
                element.FeedPet();
                Console.WriteLine("You just fed all the Pets in your shelter");
            }
        }

        public void CareAll()
        {
            foreach (Pet element in myRoboPets)
            {
                element.PetCare();
                Console.WriteLine("You just took all your Pets to the veteranarian");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Name       |   Species     |");
            Console.WriteLine("-----------|---------------|");
            int i = 1;
            foreach (Pet element in myRoboPets)
            {
                Console.WriteLine($" {i++} { element.Name}    |   { element.Species}    |");
            }
        }

        public override void SingleFeed()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myRoboPets[Convert.ToInt32(Console.ReadLine()) - 1];

            choicePet.FeedPet();
            Console.WriteLine($"You just oiled {choicePet.Name}!");
        }

        public virtual void SinglePlay()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myRoboPets[Convert.ToInt32(Console.ReadLine()) - 1];

            choicePet.PlayPet();
            Console.WriteLine($"You just played with {choicePet.Name}!");
        }

        public virtual void SingleCare()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myRoboPets[Convert.ToInt32(Console.ReadLine()) - 1];

            choicePet.PetCare();
            Console.WriteLine($"You just brought {choicePet.Name} in for maintenance!");
        }

        public void TimeTollToo()
        {
            foreach (RoboPet element in myRoboPets)
            {
                element.MenuTime();
            }

            
        }
    }
}

