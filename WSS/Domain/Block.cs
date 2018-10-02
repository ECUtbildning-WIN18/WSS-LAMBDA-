using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Block : AbstractBuilding
    {
        public override string BuildingType { get; } = "Block";
        public override string BuildingId { get; set; }   // "B2"
        public override string BuildingName { get; set; } // "Beta-2"
        public Dictionary<string, AbstractBuilding> MyBlock { get; set; } // Här finns alla celler i Block
        public Cell Cell { get; set; }

        public Block(string buildingID, string buildingName)
        {
            BuildingId = buildingID;
            BuildingName = buildingName;
        }

        public void ListCellsInBlock()
        {
            if (MyBlock.Count == 0)
            {
                Console.WriteLine("The block contains no cell");
            }
            else
            {
                foreach (var prisonCell in MyBlock)
                {
                    Console.WriteLine($" { prisonCell.Value.BuildingId } ");
                }
            }

        }
    }
}
