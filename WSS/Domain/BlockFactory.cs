using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class BlockFactory : BuildingFactory
    {
        public string BlockId { get; }
        public string BlockName { get; }

        public BlockFactory(string buildingID, string buildingName)
        {
            BlockId = buildingID;
            BlockName = buildingName;
        }

        public override AbstractBuilding GetBuilding()
        {
            return new Block(BlockId, BlockName);
        }
    }
}
