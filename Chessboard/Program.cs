using Chessboard;
using Newtonsoft.Json;

Console.WriteLine("\nMitt schackbräde");
Console.WriteLine("------------------------------------\n");

// Byt for loop!!!
bool isValidInput = false;
bool isValidInt = false;

int boardSize = 0;
string ownerName = "";


while (!isValidInput)
{
    Console.Write("Ange ditt namn: ");
    string nameInput = Console.ReadLine();



    if (!int.TryParse(nameInput, out int testName))
    {
        ownerName = nameInput;

        while (!isValidInt)
        {
            Console.Write("Ange brädets storlek (3-50): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int size))
            {
                if (size >= 3 && size <= 50)
                {
                    Console.WriteLine($"Lyckades! Nya brädstorlek är {size}.");
                    isValidInt = true;
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
        }

    }
    else
    {
        Console.WriteLine("Skriv ditt namn igen");
    }


}

ChessBoard board = new ChessBoard(boardSize, ownerName);

board.BuildChessBoard();

// Convert till Json
string json = JsonConvert.SerializeObject(board, Formatting.Indented);
File.WriteAllText("Owner.json", json);

