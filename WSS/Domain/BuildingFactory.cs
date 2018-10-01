using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    abstract class BuildingFactory
    {

        public abstract AbstractBuilding GetBuilding();
    }
}
