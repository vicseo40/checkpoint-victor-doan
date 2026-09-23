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

        public Search()
        {
            Input = new ValidateInput();
            AllSavedBoards = new List<ChessBoard>();

            string filePath = "Owners.json";

            if (File.Exists(filePath))
            {
                string existingFile = File.ReadAllText(filePath);
                AllSavedBoards = JsonConvert.DeserializeObject<List<ChessBoard>>(existingFile);
                FindSingleOwner();
            }
        }

        public void FindSingleOwner()
        {
            Console.Write("Vem vill du hitta: ");
            string nameInput = Console.ReadLine();
            string owner = nameInput;

            for (int i = 0; i < AllSavedBoards.Count; i++)
            {
                if (owner == AllSavedBoards[i].Owner)
                {
                    string ownerName = AllSavedBoards[i].Owner;
                    int size = AllSavedBoards[i].BoardSize;
                    Console.WriteLine($"Owner exists!");
                    Console.WriteLine($"Owner name is: {ownerName}. Board size is: {size}");
                    i = AllSavedBoards.Count;
                }
                else if (i >= AllSavedBoards.Count-1)
                {
                    Console.WriteLine($"Owner does not exist!");

                }
            }
        }

        public void FindAllOwners() 
        {
            for (int i = 0; i < AllSavedBoards.Count; i++)
            {
                string ownerName = AllSavedBoards[i].Owner;
                int size = AllSavedBoards[i].BoardSize;
                Console.WriteLine($"Owner name is: {ownerName}. Board size is: {size}");
            }
        }


    }
}
