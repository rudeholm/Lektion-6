/* 12.Den robusta sifferinmataren (Felhantering i snurra)
Skapa ett program som ber användaren mata in ett giltigt heltal. Om användaren skriver in text
eller felaktiga tecken ska programmet skriva ut ett felmeddelande och be om inmatningen igen.
Detta ska upprepas i en snurra tills int.TryParse lyckas returnera ett giltigt tal. */

int number;
bool success = false;

do
{
    Console.Write("Ange ett heltal: ");
    success = int.TryParse(Console.ReadLine(), out number);

    if (success == false)
    {
        Console.WriteLine("Fel: Felaktigt format, ej ett heltal, eller utanför giltigt intervall.");
        Console.WriteLine("Min: {0} | Max: {1}", int.MinValue, int.MaxValue);
    }
}
while (success == false);

Console.WriteLine($"Ditt heltal: {number}");