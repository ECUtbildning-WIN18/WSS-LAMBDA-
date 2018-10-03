using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSS.Domain
{
    class Block : AbstractBuilding
    {
        public override string BuildingType { get; } = "Block";
        public override string BuildingId { get; set; }   // "B2"
        public override string BuildingName { get; set; } // "Beta-2"
        public Dictionary<string, Cell> MyCellsInBlock { get; } = new Dictionary<string, Cell>();  // Här finns alla celler i Block
        public Cell Cell { get; set; }

        public Block(string buildingID, string buildingName)
        {
            BuildingId = buildingID;
            BuildingName = buildingName;
        }


        public void ListCellsInBlock()
        {
            if (!MyCellsInBlock.Any())
            {
                Console.WriteLine("The block contains no cell");
            }
            else
            {
                foreach (var prisonCell in MyCellsInBlock)
                { 
                    Console.WriteLine($" { prisonCell.Value.BuildingId } ");
                }
            }

        }
    }
}
