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
    }
}
            


        
    

