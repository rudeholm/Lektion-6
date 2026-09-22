/* 10.Textanalysatorn (foreach och char)
Låt användaren mata in en valfri mening i konsolen. Använd en foreach-snurra för och stega
igenom varje enskilt tecken (char) i strängen. Programmet ska räkna hur många mellanslag
meningen innehåller och skriva ut resultatet. */

Console.Clear();
Console.WriteLine("Skriv in valfri text:");
Console.Write("> ");
string text = Console.ReadLine();

int spaces = 0;
foreach (var character in text)
{
    if (character == ' ')
    {
        spaces++;
    }
}

Console.WriteLine("\nTexten innehåller {0} mellanslag.", spaces);