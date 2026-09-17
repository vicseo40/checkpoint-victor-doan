Chessboard
Ett enkelt konsolprogram som ritar ett schackbräde och sparar datan till en JSON-fil.

Krav
En data
.NET 10

Kom igång (Klona, bygg och kör)
Klona projektet: git clone https://github.com/vicseo40/checkpoint-victor-doan.git

Gå in i mappen: cd [mappens namn]

Bygg projektet: dotnet build

Kör programmet: dotnet run

Exempel på användning
Giltig input:
Ange ditt namn: Victor
Ange brädets storlek (3-50): 4

Programmets resultat:
Ägare namn är: Victor
◼◻︎◼◻︎
◻︎◼◻︎◼
◼◻︎◼◻︎
◻︎◼◻︎◼
(Programmet skapar också en fil som heter Owner.json).

Klasser och metoder
ChessBoard: Klassen som bygger själva brädet.

ReadOwnerName(): Läser in och kontrollerar användarens namn.

ReadBoardSize(): Ser till att användaren väljer en siffra mellan 3 och 50.

BuildChessBoard(): Ritar ut mönstret i konsolen.

Användning av AI:
Vi använde AI för att få råd om hur vi kunde skriva koden bättre och förstå varför. AI föreslog att vi skulle flytta metoderna för input-validering till klassen Checkpoint. Vi höll med om att det var en bra idé och lade till det.

NuGet-paket
Newtonsoft.Json: Vi använder detta för att enkelt kunna konvertera (serialisera) vårt C#-objekt till text och spara det i en JSON-fil.

Så här samarbetar vi
En person delar sin skärm, och vi går igenom projektplanering, problemlösning och kodning tillsammans.
Vi använder också Git för att arbeta tillsammans:

Commit: Vi sparar våra ändringar lokalt med ett kort meddelande.

Pull: Vi laddar ner den senaste koden från GitHub för att undvika konflikter.

Push: Vi laddar upp våra färdiga ändringar till GitHub så att alla kan se dem.