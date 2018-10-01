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
        public Cell Cell { get; set; }

        public Block(string buildingID, string buildingName)
        {
            BuildingId = buildingID;
            BuildingName = buildingName;
        }
    }
}
