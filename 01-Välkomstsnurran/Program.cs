/* 1.Välkomstsnurran(while)
    Skapa ett program som frågar användaren om de vill fortsätta köra programmet. Så länge
användaren svarar 'ja' (eller 'J'), ska programmet skriva ut 'Snurrar vidare...' och fråga igen. Om de
skriver något annat ska snurran avslutas med ett hejdå-meddelande. */


while (true)
{
    Console.Write("Vill du fortsätta snurra? ");
    string input = Console.ReadLine().Trim().ToLower();
    if (input == "ja" || input == "j")
    {
        Console.WriteLine("Snurrar vidare...");
    }
    else
    {
        Console.WriteLine("Hej då!");
        break;
    }
}