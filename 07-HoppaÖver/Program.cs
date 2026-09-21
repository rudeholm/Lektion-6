/* 7. Hoppa över dolda filer (continue)
Skapa en array med filnamn (strängar) där vissa filer börjar med en punkt '.' (vilket symboliserar
dolda filer, t.ex. '.config', 'index.html', '.git', 'styles.css'). Använd en snurra för att skriva ut
filnamnen, men använd continue för att hoppa över alla dolda filer så att de inte visas på skärmen. */

string[] files = [
    ".",
    "..",
    ".config",
    ".git",
    "index.html",
    "styles.css",
    ];

foreach (var filename in files)
{
    if (filename.StartsWith('.'))
        continue;

    Console.WriteLine(filename);
}