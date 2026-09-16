using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessBoard
    {
        public string Owner { get; set; }
        public int BoardSize { get; set; }
        public ChessBoard(int boardSize, string owner)
        {
            BoardSize = boardSize;
            Owner = owner;
        }
        public void BuildChessBoard()
        {
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
