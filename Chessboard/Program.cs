Console.WriteLine("Mitt schackbräde");
Console.WriteLine("------------------------------------\n");


bool isValidInput = false;
int boardSize = 0;

while (!isValidInput)
{
    Console.Write("Ange brädets storlek (3-50): ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int size))
    {
        if (size >= 3 && size <= 50)
        {
            Console.WriteLine($"Lyckades! Nya brädstorlek är {size}.");
            isValidInput = true;
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

    for (int i = 0; i < boardSize; i++)
    {
        Console.WriteLine(); // Går ner ett kolumn vid värje loop
        for (int j = 0; j < boardSize; j++)
        {
            if (i % 2 == 0) // Om raden är jämn skriver vi ut "X" först, annars "O" först om raden är udda
            {
                if (j % 2 == 0)
                {
                    Console.Write("◼"); // Skriv ut antalet "X" vid varje kolumn
                }
                else
                {
                    Console.Write("◻︎"); // Skriv ut antalet "O" vid varje kolumn
                }
            }
            else
            {
                if (j % 2 == 0)
                {
                    Console.Write("◻︎"); // Skriv ut antalet "O" vid varje kolumn
                }
                else
                {
                    Console.Write("◼"); // Skriv ut antalet "X" vid varje kolumn
                }
            }

        }
    }
}
