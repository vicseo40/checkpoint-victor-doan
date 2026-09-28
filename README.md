# Chessboard

## Hur den funkar
Ett enkelt konsolprogram som ritar ett schackbräde och sparar datan till en JSON-fil.
När man kör programmet användaren får välja fyra val genom att skriva in ett nummer mellan 1-4

#### Kör exempel
<img width="589" height="235" alt="image" src="https://github.com/user-attachments/assets/940a745b-367c-41e1-878d-1c404d6bd42e" />

### Exempel på användning
<img width="589" height="621" alt="image" src="https://github.com/user-attachments/assets/e3232241-0bb8-494e-9696-b9f5580ad815" />

(Programmet skapar också en fil som heter Owner.json där den sparas alla användarens namn och schäckstorlek).

## Krav
En data
.NET 10

## Kom igång (Klona, bygg och kör)
Klona projektet: 
````
git clone https://github.com/vicseo40/checkpoint-victor-doan.git
````
Söka och komma in i mappen i terminalen: 
````
cd [mappens namn]
````

Bygg projektet:
````
dotnet build
````

Kör programmet:
````
dotnet run
````

## Klasser och metoder
#### Program: Den viktigaste som kör själva programmet
- CreateChessBoard(): En metod som skapa och köra chessboard
- Main(): Fråga för användarens input mellan 1-4 och körs programmet beror på vilken siffra de valde
#### ChessBoard: Klassen som bygger och spara själva brädet.
- BuildChessBoard(): Ritar ut mönstret i konsolen.
- SaveChessBoard(): Sparas användarens namn och schackbräden storlek i en JSON-fil

#### ValidateInput: Klassen som validera värde som användaren matas in
- ValidateString(): Validera användarens namn.
- ValidateInt(): Validera schackbrädens storlek

#### Search: Klassen som hittar användare genom att matas in deras namn
- FindSingleOwner(): Den hittar ett specific namn som finns i JSON-filen
- FindAllOwner(): Den hittar alla namn som finns i JSON-filen

## Användning av AI:
Vi använde AI för att få råd om hur vi kunde skriva koden bättre och förstå varför. AI föreslog att vi skulle flytta metoderna för input-validering till klassen Checkpoint. Vi höll med om att det var en bra idé och lade till det. Tidigare hanterade vi valideringen av namn och schackbrädets storlek på samma ställe med hjälp av nästlade while-loopar. Vi tänkte att det skulle bli betydligt enklare att läsa och vid behov ändra koden om vi delade upp valideringen och flyttade den från program.cs till klassen för schackbrädet.

## NuGet-paket
Newtonsoft.Json: Vi använder detta för att enkelt kunna konvertera (serialisera) vårt C#-objekt till text och spara det i en JSON-fil.

## Så här samarbetar vi
En person delar sin skärm, och vi går igenom projektplanering, problemlösning och kodning tillsammans.
Vi använder också Git för att arbeta tillsammans:
- Commit: Vi sparar våra ändringar lokalt med ett kort meddelande.
- Pull: Vi laddar ner den senaste koden från GitHub för att undvika konflikter.
- Push: Vi laddar upp våra färdiga ändringar till GitHub så att alla kan se dem.
