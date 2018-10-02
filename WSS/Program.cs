using System;
using System.Collections.Generic;
using WSS.Domain;


namespace WSS
{
    class Program
    {
        static void Main(string[] args)
        {
            //BuildingFactory myBuildingFactory;  // "Infrastructure builder"

            Prison lambdaPrison;
            lambdaPrison = PrisonInitializer.InitiatePrison();
            MenuHandler menuHandler = new MenuHandler(lambdaPrison);
            menuHandler.StartMenu();

            Console.ReadKey();


            //DeleteBlock(myPrison, "A2");

            //ListBlocks(myPrison);

            // myBuildingFactory = new BlockFactory("A1", "Alpha One");   // så här skapas "block builder"... på samma sätt med en en Cellfactory
            //AbstractBuilding myBlock = myBuildingFactory.GetBuilding();    //myBuilding använder den overridade metoden o skapar ett
            //myPrison.Add(myBlock.BuildingId, myBlock);  // lägger till ett block i myPrison...done!

            // Nu kan vi lista eller ta bort block eller visa enskilda block, exempelvis...:
            //Console.WriteLine($"Building type: { myPrison["A1"].BuildingType}   Building name: {myPrison["A1"].BuildingName}");

            //MenuInfrastructure menuInfrastructure = new MenuInfrastructure();

            Console.ReadKey();
        }

        
    }
}
