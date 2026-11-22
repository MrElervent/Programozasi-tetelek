string elsoVSZK = "Nyári napnak alkonyúlatánál Megállék a kanyargó Tiszánál Ott, hol a kis Túr siet beléje, Mint a gyermek anyja kebelére.";
string masodikVSZK = "A folyó oly símán, oly szelíden Ballagott le parttalan medrében, Nem akarta, hogy a nap sugára Megbotoljék habjai fodrába'.";

int db1 = 0;
int db2 = 0;
char[] maganhangzok = ['a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű', 'A', 'Á', 'E', 'É', 'I', 'Í', 'O', 'Ó', 'Ö', 'Ő', 'U', 'Ú', 'Ü', 'Ű'];


foreach (char ch in elsoVSZK)
{
    if (maganhangzok.Contains(ch))
    {
        db1++;
    }
}

foreach (char ch in masodikVSZK)
{
    if (maganhangzok.Contains(ch))
    {
        db2++;
    }
}

if(db1 > db2)
{
    Console.WriteLine($"A Tisza c. vers első versszakában van több magánhangzó({db1}db)");
}
else if(db2 > db1)
{
    Console.WriteLine($"A Tisza c. vers második versszakában van több magánhangzó({db2}db)");
}
else
{
    Console.WriteLine($"A Tisza c. vers első és második versszakában ugyanannyi magánhangzó van({db1}db és {db2}db)");
}