using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Prison
    {
        public string Name { get; } = "Lambda prison";
        public Dictionary<string, Block> MyPrison { get; set; } = new Dictionary<string, Block>();

        public Prison()
        {
        }


        public void ListBlocks()
        {          
            foreach (var prisonBlock in MyPrison)
            {
                Console.WriteLine($" { prisonBlock.Value.BuildingId } ");
            }
        }


        public void DeleteBlock( Prison prison, string blockId )
        {
            Console.WriteLine($"Are you sure want to delete {blockId}?");
            Console.WriteLine("(Y)es    (N)o");
            string choice = Console.ReadLine().ToUpper();
            if (choice == "Y")
            {
                prison.MyPrison.Remove(blockId);
                Console.WriteLine($"You deleted block {blockId}");
            }
            else if(choice == "N")
            {
            }
            else
            {
                Console.WriteLine("You can only choose Yes or No");
                Console.Clear();
                DeleteBlock(prison,blockId);
            }

        }


        public void ViewBlock(string key)
        {
            if (MyPrison.ContainsKey(key))
            {
                AbstractBuilding myBlock = MyPrison[key];
                Console.WriteLine($"\n # {myBlock.BuildingType} {myBlock.BuildingId} {myBlock.BuildingName}\n");
            }
        }


        public void AddBlock(Prison prison)
        {
            Console.Write("BlockId: ");
            string id = Console.ReadLine();
            Console.Write("BlockName: ");
            string name = Console.ReadLine();

            Block newBlock = new Block(id, name);
            prison.MyPrison.Add(newBlock.BuildingId, newBlock);

            Console.WriteLine($"You added block {id}");
        }
    }
}
