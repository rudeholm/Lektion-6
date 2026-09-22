/* 11.Temperaturloggen (Blandade snurror)
Skapa en array med flyttal (double) som representerar temperaturmätningar under en dag. Loopa
igenom mätningarna och räkna ut medeltemperaturen samt hitta den högsta temperaturen. (Gör
detta helt utan inbyggda LINQ-metoder som .Max() eller .Average()). */

double[] tempReadings = [
    23.7,
    24.4,
    25.4,
    25.9,
    26.8,
    26.0,
    25.8,
    25.2,
    24.6,
    23.5,
    ];

double averageTemp = 0.0;
double highestTemp = 0.0;

foreach (var temp in tempReadings)
{
    if (temp > highestTemp)
        highestTemp = temp;

    averageTemp += temp;
}

averageTemp /= tempReadings.Length;

Console.WriteLine("Högsta uppmätta temperatur: {0} °C", highestTemp);
Console.WriteLine("Medeltemperatur: {0} °C", averageTemp);



