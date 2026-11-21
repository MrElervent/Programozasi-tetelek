string[] nevnapok = ["Malvin","Petra","Helga","Ferenc","Aurél","Brúnó","Amália","Koppány","Dénes","Gedeon","Brigitta","Miksa","Kálmán","Helén","Teréz","Gál","Hedvig",
                     "Lukács","Nándor","Vendel","Orsolya","Előd","Gyöngyi","Salamon","Blanka","Dömötör","Szabina","Simon","Nárcisz","Alfonz","Farkas"];

string keresett = "Lukács";
int sorszam = 0;

for(int i = 0; i < nevnapok.Length; i++)
{
    if(keresett == nevnapok[i])
    {
        sorszam = i + 1;
    }
}
Console.WriteLine($"Lukács névnapja Október {sorszam}. lesz");