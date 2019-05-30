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
        OrganicPet organicPet;
        Shelter shelter;
        RoboPet roboPet;
        RoboticShelter roboShelter;

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
            shelter = new Shelter("Shelter");
            roboShelter = new RoboticShelter("RoboShelter");
        
            while (toPlay)
            {

                Console.WriteLine("Please choose which Shelter you would like to visit: \n1. Organic \n2. Robotic");
                int shelterType = Convert.ToInt32(Console.ReadLine());
                shelter.TimeToll();
                roboShelter.TimeTollToo();

                if (shelterType.Equals(1))
                {
                    organicPet = new OrganicPet("", "");
                    Menu startMenu = new Menu();
                    int menuResponse = menu.MainMenu();

                    switch (menuResponse)
                    {
                        case 1:
                            organicPet.CreatePet();
                            shelter.AddPetList(organicPet);
                            break;
                        case 2:
                            Console.WriteLine("Choose which activity you would like to do:");
                            Console.WriteLine("1. Play with your Pets");
                            Console.WriteLine("2. Feed your Pets");
                            Console.WriteLine("3. Take your Pets to the Veterinarian");
                            Console.WriteLine("4.Return to Main Menu");
                            int interactionResponse = Convert.ToInt32(Console.ReadLine());

                            switch (interactionResponse)
                            {
                                case 1:
                                    Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to play all the pets in your shelter");
                                    int playOption = Convert.ToInt32(Console.ReadLine());

                                    switch (playOption)
                                    {
                                        case 1:
                                            shelter.PetList();
                                            break;
                                        case 2:
                                            shelter.PlayAll();
                                            break;
                                        default:
                                            Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to play all the pets in your shelter.");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Please type: \n\"1\" to feed one pet or \n\"2\" to feed all the pets in your shelter");
                                    int feedOption = Convert.ToInt32(Console.ReadLine());

                                    switch (feedOption)
                                    {
                                        case 1:
                                            shelter.SingleFeed();
                                            break;
                                        case 2:
                                            shelter.FeedAll();
                                            break;
                                        default:
                                            Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to feed all the pets in your shelter.");
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to take all your pets to the veteranarian.");
                                    int careOption = Convert.ToInt32(Console.ReadLine());

                                    switch (careOption)
                                    {
                                        case 1:
                                            shelter.PetList();
                                            break;
                                        case 2:
                                            shelter.CareAll();
                                            break;
                                        default:
                                            Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to take all your pets to the veteranarian.");
                                            break;
                                    }
                                    break;
                                case 4:
                                    return;
                                default:
                                    Console.WriteLine("Please choose an interaction");
                                    break;
                            }
                            break;
                        case 3:
                            shelter.GetInfo();
                            break;
                        case 4:
                            shelter.GetStatus();
                            break;
                        case 5:
                            shelter.PetList();
                            roboShelter.PetList();
                            break;
                        case 6:
                            shelter.RemovePetList(organicPet);
                            break;
                        case 7:
                            if (menuResponse == 7)
                            {
                                toPlay = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Not a valid entry.");
                            break;
                    }
                }

                else if (shelterType.Equals(2))
                {
                    roboPet = new RoboPet("", "");
                    Menu startMenu = new Menu();
                    int menuResponse = menu.MainMenu();

                    switch (menuResponse)
                    {
                        case 1:
                            roboPet.CreatePet();
                            roboShelter.AddRoboPetList(roboPet);
                            break;
                        case 2:
                            Console.WriteLine("Choose which activity you would like to do:");
                            Console.WriteLine("1. Play with your Pets");
                            Console.WriteLine("2. Feed your Pets");
                            Console.WriteLine("3. Take your Pets to the Veterinarian");
                            Console.WriteLine("4.Return to Main Menu");
                            int interactionResponse = Convert.ToInt32(Console.ReadLine());

                            switch (interactionResponse)
                            {
                                case 1:
                                    Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to play all the pets in your shelter");
                                    int playOption = Convert.ToInt32(Console.ReadLine());

                                    switch (playOption)
                                    {
                                        case 1:
                                            roboShelter.PetList();
                                            break;
                                        case 2:
                                            roboShelter.PlayAll();
                                            break;
                                        default:
                                            Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to play all the pets in your shelter.");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to play all the pets in your shelter");
                                    int feedOption = Convert.ToInt32(Console.ReadLine());

                                    switch (feedOption)
                                    {
                                        case 1:
                                            roboShelter.PetList();
                                            break;
                                        case 2:
                                            roboShelter.FeedAll();
                                            break;
                                        default:
                                            Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to feed all the pets in your shelter.");
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to take all your pets to the veteranarian.");
                                    int careOption = Convert.ToInt32(Console.ReadLine());

                                    switch (careOption)
                                    {
                                        case 1:
                                            roboShelter.PetList();
                                            break;
                                        case 2:
                                            roboShelter.CareAll();
                                            break;
                                        default:
                                            Console.WriteLine("Please type: \n\"1\" to select a pet or \n\"2\" to take all your pets to the veteranarian.");
                                            break;
                                    }
                                    break;
                            }       break;
                            case 3:
                                    roboShelter.GetInfo();
                                    break;
                            case 4:
                                    roboShelter.GetStatus();
                                    break;
                            case 5:
                                    shelter.PetList();
                                    roboShelter.PetList();
                                    break;
                            case 6:
                                    roboShelter.RemoveRoboPet(roboPet);
                                    break;
                            case 7:
                                if (menuResponse == 7)
                                {
                                    toPlay = false;
                                }
                                break;
                            default:
                                    Console.WriteLine("Not a valid entry.");
                                    break;
                    }
                }
                
                else
                {
                    Console.WriteLine("Please enter the value \"1\" for Organic Pets or \"2\" for Robotic Pets");
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
            Console.WriteLine("6. Remove a Pet from Shelter");
            Console.WriteLine("7. Quit");
            int menuResponse = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return menuResponse;
        }
    }
}