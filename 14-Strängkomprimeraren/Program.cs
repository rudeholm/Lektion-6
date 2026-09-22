/* 14.Sträng-komprimeraren (Advanced Extramaterial)
Skapa en algoritm med en for-snurra som tar en sträng med upprepade tecken (t.ex.
'AAABBBCCDAA') och komprimerar den till att visa tecknet följt av antalet upprepningar (t.ex.
'A3B3C2D1A2'). Kräver noggrann kontroll över indexeringen i snurran. */

string originalText = "AAABBBCCDAA";
string compressedText = "";

char current = originalText.First();
int counter = 1;

for (int i = 1; i <= originalText.Length; i++)
{
    if (i < originalText.Length && current == originalText[i])
    {
        counter++;
        continue;
    }

    compressedText += $"{current}{counter}";
    counter = 1;

    if (i < originalText.Length)
        current = originalText[i];
}

Console.WriteLine("Original-sträng: {0} (Längd: {1})", originalText, originalText.Length);
Console.WriteLine("Komprimerad sträng: {0} (Längd: {1})", compressedText, compressedText.Length);

