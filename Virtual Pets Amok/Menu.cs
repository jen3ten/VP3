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

