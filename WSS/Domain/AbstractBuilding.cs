using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    abstract class AbstractBuilding
    {
        public abstract string BuildingType { get; }
        public abstract string BuildingId { get; set; }
        public abstract string BuildingName { get; set; }
    }
}
