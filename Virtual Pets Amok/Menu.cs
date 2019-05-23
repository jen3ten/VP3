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
                        firstPet.FeedPet();
                        break;
                    case 3:
                        firstPet.PlayPet();
                        break;
                    case 4:
                        firstPet.VisitVet();
                        break;
                    case 5:
                        firstPet.GetInfo();
                        break;
                    case 6:
                        firstPet.GetStatus();
                        break;
                    case 7:
                        shelter.PetList();
                        break;
                    case 8:
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
            Console.WriteLine("2. Feed my Pet");
            Console.WriteLine("3. Play with my Pet");
            Console.WriteLine("4. Take My Pet to the veternarian");
            Console.WriteLine("5. Check My Pet Info");
            Console.WriteLine("6. Check My Pet Status");
            Console.WriteLine("7. View Shelter");
            Console.WriteLine("8. Quit");
            int menuResponse = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return menuResponse;
        }

    }

}