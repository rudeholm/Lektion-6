/* 6. Sökandet efter guld (break)
Skapa en array med strängar som representerar föremål i en ryggsäck (t.ex. 'Rep', 'Fackla', 'Guld',
'Karta', 'Kompass'). Använd en snurra för att söka efter 'Guld'. Så fort programmet hittar guld ska
det skriva ut 'Guld hittat!' och omedelbart avbryta snurran med break. */

string[] backpack = [
    "Rep",
    "Fackla",
    "Elddon",
    "Guld",
    "Karta",
    "Kompass",
    ];

foreach (var item in backpack)
{
    Console.WriteLine(item);
    if (item.Equals("Guld"))
    {
        Console.WriteLine("---");
        Console.WriteLine("Guld hittat!");
        break;
    }
}
