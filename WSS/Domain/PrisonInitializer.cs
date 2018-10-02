using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class PrisonInitializer
    {

        public static Prison InitiatePrison()
        {
            Dictionary<string, AbstractBuilding> myPrison = new Dictionary<string, AbstractBuilding>();

            AbstractBuilding myBlock1, myBlock2, myBlock3, myBlock4, myBlock5;

            myBlock1 = new Block("A1", "Alpha One");
            myBlock2 = new Block("A2", "Alpha Two");
            myBlock3 = new Block("B1", "Beta One");
            myBlock4 = new Block("B2", "Beta Two");
            myBlock5 = new Block("C3", "Ceasar One");

            myPrison.Add(myBlock1.BuildingId, myBlock1);
            myPrison.Add(myBlock2.BuildingId, myBlock2);
            myPrison.Add(myBlock3.BuildingId, myBlock3);
            myPrison.Add(myBlock4.BuildingId, myBlock4);
            myPrison.Add(myBlock5.BuildingId, myBlock5);

            return new Prison(myPrison);
        }
    }
}
