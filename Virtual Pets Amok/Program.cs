using System;

namespace Virtual_Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toPlay = true;
            Menu menu = new Menu();
            Console.WriteLine("Welcome to VP3, type \"start\" to begin.\nType \"quit\" at any time to exit.");
            string playResponse = Console.ReadLine().ToLower();

            if (playResponse.Equals("quit"))
            {
                toPlay = false;
            }

            Pet firstPet = new Pet("", "");

            while (toPlay)
            {
                Console.WriteLine("\nLet's Play!");

                Menu startMenu = new Menu();
                int menuResponse = menu.MainMenu();
                
                if (menuResponse == 1)
                 {
                    Console.WriteLine("Please choose which pet you would like to add to your shelter: Goldfish, Moose, Ferret, or Penguin");
                    string petSpecies = Console.ReadLine();
                    Console.WriteLine("Please give a name to your " + petSpecies);
                    string petName = Console.ReadLine();
                    firstPet = new Pet(petName, petSpecies);
                 }

                if (menuResponse == 2)
                {
                    Console.WriteLine("You just fed your pet!");
                    firstPet.Hunger = firstPet.Hunger-3;
                    firstPet.Boredom++;
                }

                if (menuResponse == 3)
                {
                    Console.WriteLine("You just played with your pet!");
                    firstPet.Boredom = firstPet.Boredom-2;
                    firstPet.Hunger = firstPet.Hunger+3;
                    int injuryChance = new Random().Next(1, 101);
                    if(injuryChance <= 100)
                    {
                        firstPet.Health = firstPet.Health-5;
                        Console.WriteLine("Oh No! Your pet got hurt while playing. You need to take them to the vet!/n");
                    }

                }
                if (menuResponse == 4)
                {
                    Console.WriteLine("You want to take your pet in for a check up.");
                    firstPet.Health++;
                    firstPet.Boredom++;
                    firstPet.Hunger++;
                }
                if (menuResponse == 5)
                {
                    firstPet.GetInfo();
                    Console.ReadLine();

                }
                if (menuResponse == 6)
                {
                            Console.WriteLine("Your pet's hunger is " + firstPet.Hunger);
                            Console.WriteLine("Your pet's boredom level is " + firstPet.Boredom);
                            Console.WriteLine("Your pet's health level is " + firstPet.Health);
                            Console.ReadLine();
                }

                if (menuResponse == 7)
                {
                    return;
                }


                


            }
        }
    }
}
            


        
    

