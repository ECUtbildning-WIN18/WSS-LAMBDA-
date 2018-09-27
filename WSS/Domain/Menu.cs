using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Menu
    {
        public void StartMenu()
        {
            int choice = 0;
            bool check = false;
            Console.Clear();

            Console.WriteLine("1 Infrastructure\n2 Prisoners\n3 Wedlock devices\n4 Exit\n");
            Console.Write("> _");
            do
            {
                string answer = Console.ReadLine();
                check = int.TryParse(answer, out choice);
                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You may only choose numbers");
                    Console.ResetColor();
                }

            } while (check == false);
            switch(choice)
            {
                case 1:
                    Infrastructure();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Environment.Exit(4);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only choose between 1 and 4");
                    Console.ResetColor();
                    Console.ReadKey();
                    StartMenu();
                    break;

            }
        }


        public void Infrastructure()
        {
            Console.Clear();
            int choice = 0;
            bool check = false;
            Console.WriteLine("1 List blocks\n2 Add block\n3 Back to main menu");
            Console.Write("> _");
            Console.WriteLine("\n\n\nPress Esc to return to previous view.");

            var key = Console.ReadKey();
            if( key.Key==ConsoleKey.Escape)
            {
                StartMenu();
            }

            do
            {
                Console.WriteLine("   ");
                string answer = Console.ReadLine();
                check = int.TryParse(answer, out choice);
                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You may only choose numbers");
                    Console.ResetColor();
                }

            } while (check == false);

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    StartMenu();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only choose between 1 and 3");
                    Console.ResetColor();
                    Console.ReadKey();
                    Infrastructure();
                    break;

            }

        }







    }
}
