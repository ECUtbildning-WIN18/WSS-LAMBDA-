using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class MenuInfrastructure
    {
        public Menu StartMenu { get; set; }

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
                    StartMenu.StartMenu();
                    break;

                case ConsoleKey.Escape:
                    StartMenu.StartMenu();
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
