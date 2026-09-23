using Chessboard;
using Newtonsoft.Json;

Console.WriteLine("\nMitt schackbräde");
Console.WriteLine("------------------------------------\n");

static void CreateChessBoard()
{
    // Skapa och köra object
    ChessBoard board = new ChessBoard(3, 50);
    board.BuildChessBoard();

    // Convert till Json
    List<ChessBoard> allBoards = new List<ChessBoard>();
    string filePath = "Owners.json";

    if (File.Exists(filePath))
    {
        string existingJson = File.ReadAllText(filePath);
    }

}



