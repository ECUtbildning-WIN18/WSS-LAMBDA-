using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class CellMenu
    {
        public BlockMenu BlockMenu { get; set; }
        public Menu StartMenu { get; set; }

        public void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("1 List cell\n2 Add cell\n3 Back to main menu");
            Console.WriteLine("\nPress Esc to return to previous view.");

            Console.Write("\n> ");
            Console.ResetColor();
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Console.ReadKey();
                    ListCells();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Console.ReadKey();
                    AddCell();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    StartMenu.StartMenu();
                    break;

                case ConsoleKey.Escape:
                    BlockMenu.ListMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou can only choose between 1 and 3");
                    Console.ResetColor();
                    Console.ReadKey();
                    Menu();
                    break;
            }

        }
    }
}
