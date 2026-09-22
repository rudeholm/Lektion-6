/* 9. Menyvalet med nödutgång (while-true/break)
Skapa ett enkelt textbaserat menysystem med tre alternativ: 1. Visa profil, 2. Ändra inställningar, 3.
Avsluta. Snurran ska köra oändligt (while (true)) tills användaren väljer alternativ 3. Då ska en
break bryta snurran och stänga programmet. */


while (true)
{
    Console.Clear();
    Console.WriteLine("1. Visa profil");
    Console.WriteLine("2. Ändra inställningar");
    Console.WriteLine("3. Avsluta");
    Console.Write(">>> ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 3) break;
}