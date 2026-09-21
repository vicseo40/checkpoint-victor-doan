using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessBoard
    {

        public string Owner { get; set; }
        public int BoardSize { get; set; }
        public ChessBoard(int min, int max)
        {
            Owner = ReadOwnerName();
            BoardSize = ReadBoardSize(min, max);
        }

        public string ReadOwnerName()
        {
            string ownerName = "";
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Ange ditt namn: ");
                string nameInput = Console.ReadLine();

                // Kolla om char i en string input innehåller ett digit
                if (!nameInput.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(nameInput)) // körs bara om ditt namn är INTE ett number
                {
                    ownerName = nameInput;
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Skriv ditt namn igen");
                }


            }
            return ownerName;
        }

        public int ReadBoardSize(int min, int max)
        {
            bool isValidInt = false;
            int boardSize = 0;
            while (!isValidInt) // Loopen körs när ägaren matas in ett namn och inte ett nummer
            {
                Console.Write("Ange brädets storlek (3-50): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int size))
                {
                    if (size >= min && size <= max)
                    {
                        Console.WriteLine($"Lyckades! Nya brädstorlek är {size}.");
                        isValidInt = true;
                        boardSize = size;
                    }
                    else
                    {
                        Console.WriteLine("Fel: Talet måste vara mellan 3 och 50. Försök igen!");
                    }

                }
                else
                {
                    Console.WriteLine("Fel: Ogiltig inmatning. Försök igen! Vänligen ange ett heltal.");
                }
            }
            return boardSize;
            
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
