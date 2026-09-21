/* 2. Inmatningsskyddet (do-while)
Skapa ett program där användaren måste skriva in ett hemligt lösenord (t.ex. 'hemligt') för att
komma vidare. Använd en do-while-snurra så att användaren garanterat får skriva in lösenordet
minst en gång. Snurran upprepas tills rätt lösenord matas in. */

string password = "hemligt";
string input;

do
{
    Console.Write("Lösen? ");
    input = Console.ReadLine();
}
while (input.Equals(password) == false);