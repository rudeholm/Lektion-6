/* 5. Namnlistan (foreach)
Skapa en array eller lista med 5 valfria förnamn. Använd en foreach-snurra för att stega igenom
listan och skriva ut varje namn i konsolen i stora bokstäver (UPPERCASE). */

string[] names = [
    "Foo",
    "Bar",
    "Baz",
    "Dinkel",
    "Flärp",
    ];

foreach (var name in names)
{
    Console.WriteLine(name.ToUpper());
}