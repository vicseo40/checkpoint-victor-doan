using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class Search
    {
        public List<ChessBoard> AllSavedBoards {  get; set; }
        public ValidateInput Input {  get; set; }
        private string FilePath = "Owners.json";

        public Search()
        {
            Input = new ValidateInput();
            AllSavedBoards = new List<ChessBoard>();
        }

        public void FindSingleOwner()
        {
            if (File.Exists(FilePath))
            {
                string existingFile = File.ReadAllText(FilePath);
                AllSavedBoards = JsonConvert.DeserializeObject<List<ChessBoard>>(existingFile);
                Console.Write("Vem vill du hitta: ");
                string nameInput = Console.ReadLine();
                string owner = nameInput;
                bool ownerExits = false;

                for (int i = 0; i < AllSavedBoards.Count; i++)
                {
                    if (owner == AllSavedBoards[i].Owner)
                    {
                        string ownerName = AllSavedBoards[i].Owner;
                        int size = AllSavedBoards[i].BoardSize;
                        Console.WriteLine($"Owner exists!");
                        Console.WriteLine($"Owner name is: {ownerName}. Board size is: {size}");
                        ownerExits = true;
                    }
                    else if (i >= AllSavedBoards.Count - 1 && !ownerExits) 
                    {
                        Console.WriteLine($"Owner does not exist!");
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            
        }

        public void FindAllOwners() 
        {
            if (File.Exists(FilePath))
            {
                string existingFile = File.ReadAllText(FilePath);
                AllSavedBoards = JsonConvert.DeserializeObject<List<ChessBoard>>(existingFile);
                for (int i = 0; i < AllSavedBoards.Count; i++)
                {
                    string ownerName = AllSavedBoards[i].Owner;
                    int size = AllSavedBoards[i].BoardSize;
                    Console.WriteLine($"Owner name is: {ownerName}. Board size is: {size}");
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }


    }
}
