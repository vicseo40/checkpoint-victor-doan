using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessBoard
    {

        public string Owner { get; set; }
        public int BoardSize { get; set; }
        public ValidateInput Input { get; set; }

        public ChessBoard(int min, int max)
        {
            Input = new ValidateInput();
            Owner = ReadOwnerName();
            BoardSize = ReadBoardSize(min, max);
        }

        public string ReadOwnerName()
        {
            return Input.ValidateString();
        }

        public int ReadBoardSize(int min, int max)
        {
            return Input.ValidateInt(min, max);            
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
    }
}
