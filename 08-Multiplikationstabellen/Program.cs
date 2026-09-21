/* 8. Multiplikationstabellen (Nästlade snurror)
Skapa ett program som skriver ut multiplikationstabellen för siffrorna 1 till 5. Använd två nästlade
for-snurror (en yttre och en inre). Formatera utskriften så att den ser ut som ett snyggt rutnät (tips:
använd Console.Write istället för WriteLine för elementen på samma rad). */


Console.Write("  x  ");
for (int i = 1; i <= 5; i++)
{
    Console.Write($"{i}".PadLeft(5));
}
Console.WriteLine();
Console.Write("".PadLeft(5));
for (int i = 1; i <= 5; i++)
{
    Console.Write($"-".PadLeft(5));
}
Console.WriteLine();

for (int x = 1; x <= 5; x++)
{
    Console.Write($"{x} |".PadLeft(5));

    for (int y = 1; y <= 5; y++)
    {

        Console.Write($"{x * y}".PadLeft(5));
    }
    Console.WriteLine();
}

Console.WriteLine("\n\n\n\n");