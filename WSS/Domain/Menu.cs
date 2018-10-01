using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Menu
    {
        public MenuInfrastructure MenuInfrastructure { get; set; }

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
                    MenuInfrastructure.Infrastructure();
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
    }
}

