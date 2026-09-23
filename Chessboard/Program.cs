using Chessboard;
using Newtonsoft.Json;

Console.WriteLine("\nMitt schackbräde");
Console.WriteLine("------------------------------------\n");

static void CreateChessBoard()
{
    // Skapa och köra object
    ChessBoard board = new ChessBoard(3, 50);
    board.BuildChessBoard();
    ChessBoard.SaveChessBoard(board);
}

Search seach = new Search();



CreateChessBoard();

