using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class Search
    {
        public List<ChessBoard> AllSavedBoards {  get; set; }

        public Search()
        {
            AllSavedBoards = new List<ChessBoard>();

            string filePath = "Owners.json";

            if (File.Exists(filePath))
            {
                string existingFile = File.ReadAllText(filePath);
                AllSavedBoards = JsonConvert.DeserializeObject<List<ChessBoard>>(existingFile);
            }

            for (int i = 0; i < AllSavedBoards.Count; i++) 
            {
                string ownerName = AllSavedBoards[i].Owner;
                int size = AllSavedBoards[i].BoardSize;
                Console.WriteLine($"Owner name is: {ownerName}. Board size is: {size}");
            }
        }

        public void FindSingleOwner()
        {
            
        }

        public void FindAllOwners() 
        {
        }


    }
}
