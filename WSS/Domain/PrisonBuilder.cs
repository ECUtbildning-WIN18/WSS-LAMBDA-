using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class PrisonBuilder
    {
       public static Prison Build()
        {
            Prison prison = new Prison();

            Block myBlock1 = new Block("A1", "Alpha One");
            Block myBlock2 = new Block("A2", "Alpha Two");
            Block myBlock3 = new Block("B1", "Beta One");
            Block myBlock4 = new Block("B2", "Beta Two");
            Block myBlock5 = new Block("C1", "Ceasar One");

            prison.MyPrison.Add(myBlock1.BuildingId, myBlock1);
            prison.MyPrison.Add(myBlock2.BuildingId, myBlock2);
            prison.MyPrison.Add(myBlock3.BuildingId, myBlock3);
            prison.MyPrison.Add(myBlock4.BuildingId, myBlock4);
            prison.MyPrison.Add(myBlock5.BuildingId, myBlock5);

            return prison;
        }

       

        

        //public static Prison InitiatePrison()
        //{
            

        

        //    return new Prison(myPrison);
        //}
    }
}
