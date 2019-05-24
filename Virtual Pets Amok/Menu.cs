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
        Pet firstPet;

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
            Shelter shelter = new Shelter("Shelter");


            while (toPlay)
            {
                firstPet = new Pet("", "");

                Console.WriteLine("\nLet's Play!");

                Menu startMenu = new Menu();
                int menuResponse = menu.MainMenu();

                switch (menuResponse)
                {
                    case 1:
                        firstPet.CreatePet();
                        shelter.AddPetList(firstPet);
                        break;
                    case 2:
                        firstPet.Interact();
                        break;
                    case 3:
                        firstPet.GetInfo();
                        break;
                    case 4:
                        firstPet.GetStatus();
                        break;
                    case 5:
                        shelter.PetList();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Please select 1 through 8");
                        break;
                }
             
            }

        }


        public int MainMenu()
        {
            Console.WriteLine("Main Menu/nPlease choose one of the following options:");
            Console.WriteLine("1. Add a Pet!");
            Console.WriteLine("2. Interact with Pets");
            Console.WriteLine("3. Check My Pets Info");
            Console.WriteLine("4. Check My Pets Status");
            Console.WriteLine("5. View Shelter");
            Console.WriteLine("6. Quit");
            int menuResponse = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return menuResponse;
        }

    }

}