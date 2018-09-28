using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Menu
    {
        public void StartMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("1 Infrastructure\n2 Prisoners\n3 Wedlock devices\n4 Exit\n");
            Console.Write("> ");
            Console.ResetColor();

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Infrastructure();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Environment.Exit(4);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou can only choose between 1 and 4");
                    Console.ResetColor();
                    Console.ReadKey();
                    StartMenu();
                    break;

            }
        }


        public void Infrastructure()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("1 List blocks\n2 Add block\n3 Back to main menu");
            Console.WriteLine("\nPress Esc to return to previous view.");

            Console.Write("\n> ");
            Console.ResetColor();
            var input = Console.ReadKey();

            switch (input.Key) 
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    
                    Console.ReadKey();
                    Infrastructure();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    
                    Console.ReadKey();
                    Infrastructure();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    StartMenu();
                    break;

                case ConsoleKey.Escape:
                    StartMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou can only choose between 1 and 3");
                    Console.ResetColor();
                    Console.ReadKey();
                    Infrastructure();
                    break;
            }

        }

    }
}
