using Chessboard;
using Newtonsoft.Json;

class Program
{
    static void CreateChessBoard()
    {
        // Skapa och köra object
        ChessBoard board = new ChessBoard(3, 50);
        board.BuildChessBoard();
        ChessBoard.SaveChessBoard(board);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("\nMitt schackbräde");
        Console.WriteLine("------------------------------------\n");

        bool isOn = true;
        while (isOn)
        {
            Console.WriteLine("Enter (1) för att skapa ett nytt schackbräde");
            Console.WriteLine("Enter (2) för att hitta en ägare");
            Console.WriteLine("Enter (3) för att visa alla ägaren");
            Console.WriteLine("Enter (4) för att avsluta");
            Console.Write("Vad vill du göra?: ");

            string userChoice = Console.ReadLine();
            Search search = new Search();
            if (int.TryParse(userChoice, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateChessBoard();
                        break;
                    case 2:
                        search.FindSingleOwner();
                        break;
                    case 3:
                        search.FindAllOwners();
                        break;
                    case 4:
                        Console.WriteLine("Vi ses senare.");
                        isOn = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Försök igen!");
            }
        }
    }
}

