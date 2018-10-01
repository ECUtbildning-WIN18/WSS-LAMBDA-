using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Cell : AbstractBuilding
    {
        public override string BuildingType { get; } = "Cell";
        public override string BuildingId { get; set; }
        public override string BuildingName { get; set; }
        public Prisoner prisoner { get; set; }

        public Cell(string buildingId, string buildingName)
        {
            BuildingId = buildingId;
            BuildingName = buildingName;
        }
    }
}
