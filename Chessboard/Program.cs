using Chessboard;
using Newtonsoft.Json;
static void CreateChessBoard()
{
    // Skapa och köra object
    ChessBoard board = new ChessBoard(3, 50);
    board.BuildChessBoard();
    ChessBoard.SaveChessBoard(board);
}

Console.WriteLine("\nMitt schackbräde");
Console.WriteLine("------------------------------------\n");

bool isOn = true;
while (isOn)
{
    Console.WriteLine("Enter (1) to create a new chessboard");
    Console.WriteLine("Enter (2) to find a user");
    Console.WriteLine("Enter (3) to show all users");
    Console.WriteLine("Enter (4) to exit");
    Console.Write("What do you want to do?: ");

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
                Console.WriteLine("See you later.");
                isOn = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Try again!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Try again!");
    }
}






