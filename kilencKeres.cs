int[] Eszamok = [5,77,86,12,13,24,91,100,42,36];

int szam = 0;

for(int i = 0; i< Eszamok.Length; i++)
{
    if (Eszamok[i] % 9 == 0)
    {
        szam = Eszamok[i];
    }
}


Console.WriteLine($"Kilenccel osztható szám: {szam}");
