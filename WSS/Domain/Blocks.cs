using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class Blocks 
    {
        string BlockName { get; set; }
        int BlockNumber { get; set; }

        public Blocks(string blockName, int blockNumber)
        {
            BlockName = blockName;
            BlockNumber = blockNumber;
        }
        public void AddBlock()
        {
            Dictionary<string, Blocks> prisonBlocks = new Dictionary<string, Blocks>();

        }
        public void ListBlock()
        {
            

        }

    }
}
