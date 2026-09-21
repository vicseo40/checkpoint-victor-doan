using Chessboard;
using Newtonsoft.Json;

Console.WriteLine("\nMitt schackbräde");
Console.WriteLine("------------------------------------\n");


// Skapa och köra object
ChessBoard board = new ChessBoard(3, 50);
board.BuildChessBoard();

// Convert till Json
string json = JsonConvert.SerializeObject(board, Formatting.Indented);
File.WriteAllText("Owner.json", json);

