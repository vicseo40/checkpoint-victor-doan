using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessBoard
    {

        public string Owner { get; set; }
        public int BoardSize { get; set; }
        [JsonIgnore]
        public ValidateInput Input { get; set; }

        public ChessBoard()
        {

        }
        public ChessBoard(int min, int max)
        {
            Input = new ValidateInput();
            Owner = Input.ValidateString();
            BoardSize = Input.ValidateInt(min, max);
        }

        public void BuildChessBoard()
        {
            Console.WriteLine($"Ägare namn är: {Owner}");
            for (int i = 0; i < BoardSize; i++)
            {
                Console.WriteLine(); // Går ner ett kolumn vid värje loop
                for (int j = 0; j < BoardSize; j++)
                {

                    if (j % 2 == 0 && i % 2 == 0) // SKriv ◼ först och ◻︎ efter när i är jämnt
                    {
                        Console.Write("◼");
                    }
                    else if (j % 2 == 1 && i % 2 == 0)
                    {
                        Console.Write("◻︎");
                    }

                    if (j % 2 == 0 && i % 2 == 1) // SKriv ◻︎ först och ◼ efter när i är jämnt
                    {
                        Console.Write("◻︎"); // Skriv ut antalet "O" vid varje kolumn
                    }
                    else if (j % 2 == 1 && i % 2 == 1)
                    {
                        Console.Write("◼"); // Skriv ut antalet "X" vid varje kolumn
                    }

                }
            }
        }

        public static void SaveChessBoard(ChessBoard board)
        {
            // Convert till Json
            List<ChessBoard> allBoards = new List<ChessBoard>();
            string filePath = "Owners.json";

            if (File.Exists(filePath))
            {
                string existingFile = File.ReadAllText(filePath);
                allBoards = JsonConvert.DeserializeObject<List<ChessBoard>>(existingFile);
            }

            allBoards.Add(board);
            string json = JsonConvert.SerializeObject(allBoards, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
