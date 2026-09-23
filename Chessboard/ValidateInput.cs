using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ValidateInput
    {
        public string ValidateString()
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
        
        public int ValidateInt(int min, int max)
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
    }
}
