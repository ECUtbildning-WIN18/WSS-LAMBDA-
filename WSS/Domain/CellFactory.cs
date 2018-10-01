using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class CellFactory : BuildingFactory
    {
        public string BlockId { get; }
        public string BlockName { get; }

        public CellFactory(string buildingID, string buildingName)
        {
            BlockId = buildingID;
            BlockName = buildingName;
        }

        public override AbstractBuilding GetBuilding()
        {
            return new Cell(BlockId, BlockName);
        }
    }
}
