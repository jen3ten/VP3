using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pets_Amok
{
    class Menu
    {

        public Menu()
        {


        }


        public void FirstMenu()
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
                    firstPet.CreatePet();
                }

                else if (menuResponse == 2)
                {
                    firstPet.FeedPet();
                }

                else if (menuResponse == 3)
                {
                    firstPet.PlayPet();
                }
                else if (menuResponse == 4)
                {
                    firstPet.VisitVet();
                }
                else if (menuResponse == 5)
                {
                    firstPet.GetInfo();

                }
                else if (menuResponse == 6)
                {
                    firstPet.GetStatus();
                }

                else if (menuResponse == 7)
                {
                    return;
                }
                
            }

        }



        public int MainMenu()
        {
            Console.WriteLine("Main Menu/nPlease choose one of the following options:");
            Console.WriteLine("1. Add a Pet!");
            Console.WriteLine("2. Feed my Pet");
            Console.WriteLine("3. Play with my Pet");
            Console.WriteLine("4. Take My Pet to the veternarian");
            Console.WriteLine("5. Check My Pet Info");
            Console.WriteLine("6. Check My Pet Status");
            Console.WriteLine("7. Quit");
            int menuResponse = Convert.ToInt32(Console.ReadLine());
            return menuResponse;

        }

    }


}