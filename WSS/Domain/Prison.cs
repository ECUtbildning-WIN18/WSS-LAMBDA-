using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Prison
    {
        public string Name { get; } = "Lambda prison";
        public Dictionary<string, AbstractBuilding> MyPrison { get; set; }

        public Prison(Dictionary<string, AbstractBuilding> aPrisonDictionary)
        {
            MyPrison = aPrisonDictionary;
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
            Console.WriteLine($"Deleting block id: {blockId} ");
            prison.MyPrison.Remove(blockId);
        }


        public void ViewBlock(string key)
        {
            //Console.WriteLine($" { keyValue.Value.BuildingId } ");
            if (MyPrison.ContainsKey(key))
            {
                AbstractBuilding myBlock = MyPrison[key];
                Console.WriteLine($" # {myBlock.BuildingType}{myBlock.BuildingId}\n");
                Console.WriteLine($" # {myBlock.BuildingName}");
            }
        }


    }
}
