/* 3. Räknaren (for)
Skapa en for-snurra som skriver ut alla tal från 1 upp till 20 på samma rad med ett semikolon och
mellanslag emellan (t.ex. 1; 2; 3; ... 20;). */

for (int i = 1; i <= 20; i++)
{
    Console.Write(i < 20 ? $"{i}; " : $"{i};");
}

Console.WriteLine("\n\n");