﻿using System;
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
        
        public void AddRoboPetList(RoboPet firstRoboPet)
        {
            Console.WriteLine("Added to list!");
            myRoboPets.Add(firstRoboPet);
        }

        public void PetList()
        {
            foreach (Pet element in myRoboPets)
            {
                Console.WriteLine($"{element.Name} {element.Species}");
            }
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

        public void SingleFeed()
        {
            GetInfo();

            Console.WriteLine("\nPlease select a pet from your shelter:");
            Pet choicePet = myRoboPets[Convert.ToInt32(Console.ReadLine()) - 1];

            choicePet.FeedPet();
            Console.WriteLine($"You just fed {choicePet.Name}!");
        }

    }
}
