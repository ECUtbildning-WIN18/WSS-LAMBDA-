using System;
using System.Collections.Generic;
using WSS.Domain;


namespace WSS
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildingFactory myBuildingFactory;  // "Infrastructure builder"

            var myPrison = new Dictionary<string, AbstractBuilding>();  // Här lägger vi alla block

            // Skapar en "start" på ett fängelse
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

            ListBlocks(myPrison);

            DeleteBlock(myPrison, "A2");

            ListBlocks(myPrison);

            // myBuildingFactory = new BlockFactory("A1", "Alpha One");   // så här skapas "block builder"... på samma sätt med en en Cellfactory
            //AbstractBuilding myBlock = myBuildingFactory.GetBuilding();    //myBuilding använder den overridade metoden o skapar ett
            //myPrison.Add(myBlock.BuildingId, myBlock);  // lägger till ett block i myPrison...done!

            // Nu kan vi lista eller ta bort block eller visa enskilda block, exempelvis...:
            //Console.WriteLine($"Building type: { myPrison["A1"].BuildingType}   Building name: {myPrison["A1"].BuildingName}");

            //Menu menu = new Menu();
            //menu.StartMenu();


            //Console.ReadKey();
        }

        public static void ListBlocks(Dictionary<string, AbstractBuilding> prison)
        {
            foreach (var prisonBlock in prison)
            {
                Console.WriteLine($"Building type: { prisonBlock.Value.BuildingId }  Building name: {prisonBlock.Value.BuildingName}");
            }
        }

        public static void DeleteBlock(Dictionary<string, AbstractBuilding> prison, string blockId)
        {
            Console.WriteLine($"Deleting block id: {blockId} ");
            prison.Remove(blockId);
        }
    }
}
