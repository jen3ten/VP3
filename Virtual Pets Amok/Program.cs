using System;

namespace Virtual_Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toPlay = true;
            Console.WriteLine("Welcome to VP3, type \"start\" to begin.\nType \"quit\" at any time to exit.");
            string playResponse = Console.ReadLine().ToLower();

            if (playResponse.Equals("quit"))
            {
                toPlay = false;
            }

            while (toPlay)
            {
                Console.WriteLine("Let's Play!");
                Console.WriteLine("Please choose which pet you would like to add: Goldfish, Moose, Ferret, or Penguin");
                Console.ReadLine();
            }




        }
    }
}
            


        
    

