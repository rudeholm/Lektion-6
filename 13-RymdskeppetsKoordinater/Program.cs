/* 13.Rymdskeppets koordinater (Advanced Extramaterial)
Skapa ett program som ritar upp ett koordinatsystem på skärmen (t.ex. ett 5x5 rutnät) med hjälp av
nästlade snurror. Användaren ska i förväg mata in ett X- och ett Y-koordinat (mellan 1 och 5). När
snurran ritar ut koordinatsystemet ska den placera ett 'S' (Rymdskepp) på den valda positionen
och punkter '.' på alla andra positioner. */

string? inX;
string? inY;

int shipX = -1;
int shipY = -1;

bool success;

do
{
    Console.Write("Ange X-koordinat (1-5): ");
    inX = Console.ReadLine();

    Console.Write("Ange Y-koordinat (1-5): ");
    inY = Console.ReadLine();

    success = int.TryParse(inX, out shipX) && int.TryParse(inY, out shipY);

    success = success && shipX >= 1 && shipX <= 5 && shipY >= 1 && shipY <= 5;

    if (success == false)
    {
        Console.WriteLine("Fel: Felaktigt format, eller utanför giltigt intervall.");
        continue;
    }
} while (success == false);

Console.WriteLine("\n");
Console.WriteLine();

for (int y = 1; y <= 5; y++)
{
    for (int x = 1; x <= 5; x++)
    {

        Console.Write("[{0}]", (x == shipX && y == shipY) ? 'S' : '.');
    }
    Console.WriteLine();
}

Console.WriteLine("\n\n\n\n");

