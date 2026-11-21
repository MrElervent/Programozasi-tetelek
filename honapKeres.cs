string[] honapok = ["Január", "Február", "Március", "Árpilis", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December"];

Console.Write("Kérem adjon meg egy hónap nevet: ");
string keres = Console.ReadLine();
int sorszam = 0;

for(int i = 0; i<honapok.Length; i++)
{
    if(keres.ToLower()  == honapok[i].ToLower())
    {
        sorszam = i + 1;
    }
}

Console.WriteLine($"A keresett hónapja a(z) {sorszam}. hónap az évben");