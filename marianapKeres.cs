string[] nevnapok = ["Fruzsina", "Ábel", "Genovéva", "Titusz", "Simon", "Boldizsár", "Attila", "Gyöngyvér", "Marcell", "Melánia", "Ágota", "Ernő", "Veronika", "Bódog",
                    "Lóránt", "Gusztáv", "Antal", "Piroska", "Sára", "Fábián", "Ágnes", "Vince", "Zeljka", "Timót", "Pál", "Vanda", "Angelika", "Károly","Adél", "Martina", "Marcella"];


int index = 0;

while (index < 31 && nevnapok[index] != "Mária")
{
    index++;
}

if(index < 31)
{
    Console.WriteLine($"Január {index+1}. én van Mária nap");
}
else
{
    Console.WriteLine("Januárban nincs Mária nap");
}