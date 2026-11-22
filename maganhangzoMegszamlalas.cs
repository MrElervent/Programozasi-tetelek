string elsoVSZK = "Nyári napnak alkonyúlatánál Megállék a kanyargó Tiszánál Ott, hol a kis Túr siet beléje, Mint a gyermek anyja kebelére.";

int db = 0;
char[] maganhangzok = ['a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű', 'A', 'Á', 'E', 'É', 'I', 'Í', 'O', 'Ó', 'Ö', 'Ő', 'U', 'Ú', 'Ü', 'Ű'];


foreach (char ch in elsoVSZK)
{
    if (maganhangzok.Contains(ch))
    {
        db++;
    }
}

Console.WriteLine($"{db} magánhangzó van a Tisza c. vers első versszakában");