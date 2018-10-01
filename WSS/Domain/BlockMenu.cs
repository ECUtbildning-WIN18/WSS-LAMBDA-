using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class BlockMenu
    {
        public MenuInfrastructure MenuInfrastructure { get; set; }

        public void ListMenu()
        {
            myPrison.ListBlocks();
            Console.WriteLine("\n");
            Console.WriteLine("(V)iew block   (D)elete block");
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.V:
                    BlockView();
                    break;
                case ConsoleKey.D:
                    DeleteBlock();
                    break;
                case ConsoleKey.Escape:
                    MenuInfrastructure.Infrastructure();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only choose between V or D.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ResetColor();
                    Console.ReadKey();
                    ListMenu();
                    break;
            }
        }
    }
}
