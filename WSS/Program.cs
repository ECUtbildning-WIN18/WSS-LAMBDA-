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



            //Dictionary<string, AbstractBuilding> myPrison = new Dictionary<string, AbstractBuilding>();

            // Skapar en "start" på ett fängelse

            Prison myPrison = new Prison();
            Dictionary<string, AbstractBuilding> myAwesomePrison; 

            myAwesomePrison = myPrison.InitiatePrison(); // Dictionary med blocks
            //prison.ListBlocks(myAwesomePrison);

            //prison.DeleteBlock(myAwesomePrison, "A2");

            //prison.ListBlocks(myAwesomePrison);

            // myBuildingFactory = new BlockFactory("A1", "Alpha One");   // så här skapas "block builder"... på samma sätt med en en Cellfactory
            //AbstractBuilding myBlock = myBuildingFactory.GetBuilding();    //myBuilding använder den overridade metoden o skapar ett
            //myPrison.Add(myBlock.BuildingId, myBlock);  // lägger till ett block i myPrison...done!

            // Nu kan vi lista eller ta bort block eller visa enskilda block, exempelvis...:
            //Console.WriteLine($"Building type: { myPrison["A1"].BuildingType}   Building name: {myPrison["A1"].BuildingName}");

            Menu menu = new Menu(myAwesomePrison, myPrison);
            menu.StartMenu();


            Console.ReadKey();
        }

        
    }
}
