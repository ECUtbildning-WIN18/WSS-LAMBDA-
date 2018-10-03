using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WSS.Domain
{
    class MenuHandler
    {
        public Prison Prison { get; set; }

        public MenuHandler ( Prison prison )
        {
            Prison = prison;
        }

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
                    Console.WriteLine("\nFunctionality not availible yet");
                    Console.ReadKey();
                    StartMenu();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("\nFunctionality not availible yet");
                    Console.ReadKey();
                    StartMenu();
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
            Console.WriteLine();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ListBlocksMenu();
                    Console.ReadKey();
                    Infrastructure();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Prison.AddBlock(Prison);
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


        public void ListBlocksMenu()
        {
            Console.Clear();
            Console.WriteLine("***** Block List *****\n");
            Prison.ListBlocks();
            Console.WriteLine("\n");
            Console.WriteLine("(V)iew block   (D)elete block");
            Console.WriteLine("\nPress Esc to return to previous view.");
            Console.Write("\n> ");
            var input = Console.ReadKey();
            string key;
            switch (input.Key)
                
            {

                case ConsoleKey.V:  // Viewing
                    
                    Console.Clear();
                    Console.WriteLine("***** Block List *****\n");
                    Prison.ListBlocks();
                    Console.Write("\nBlock> ");
                    key = Console.ReadLine().ToUpper();
                    if (!Prison.MyPrison.ContainsKey(key))
                    {
                        Console.WriteLine("This block doesn't exist");
                        Thread.Sleep(1000);
                        ListBlocksMenu();
                    }
                    Prison.ViewBlock(key);
                    Prison.MyPrison[key].ListCellsInBlock();
                    Console.ReadKey();
                    Infrastructure();
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    Console.WriteLine("***** Block List *****\n");
                    Prison.ListBlocks();
                    Console.Write("\nDelete block> ");
                    key = Console.ReadLine().ToUpper();
                    if (!Prison.MyPrison.ContainsKey(key))
                    {
                        Console.WriteLine("This block doesn't exist");
                        Thread.Sleep(1000);
                        ListBlocksMenu();
                    }

                    Prison.DeleteBlock(Prison, key);
                    break;
                case ConsoleKey.Escape:
                    Infrastructure();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou can only choose between V or D.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ResetColor();
                    Console.ReadKey();
                    ListBlocksMenu();
                    break; 
            }
        }


        public void ListCellMenu()
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
                    //ListCells();
                    Console.WriteLine("Listing cells");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Console.ReadKey();
                    //AddCell();
                    Console.WriteLine("Adding cells");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    StartMenu();
                    break;

                case ConsoleKey.Escape:
                    ListBlocksMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou can only choose between 1 and 3");
                    Console.ResetColor();
                    Console.ReadKey();
                    //Menu();
                    break;
            }
        }
    }
}
