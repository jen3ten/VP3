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

            while (toPlay)
            {
                Console.WriteLine("\nLet's Play!");

                Menu startMenu = new Menu();
                int menuResponse = menu.MainMenu();
                Pet firstPet = new Pet("", "");
                
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
                    Console.WriteLine("You want to feed your pet.");
                }

                if (menuResponse == 3)
                {
                    Console.WriteLine("You want to play with your pet.");
                }
                if (menuResponse == 4)
                {
                    Console.WriteLine("You want to take your pet in for a check up.");
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
            


        
    

