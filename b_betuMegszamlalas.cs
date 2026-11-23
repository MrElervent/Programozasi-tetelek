List<string> szavak = new List<string> { "alma", "banán", "répa", "brokkoli", "körte", "birsalma", "uborka", "burgonya",
                                         "szilva", "paradicsom", "barack", "hagyma", "eper", "birs", "paprika" };

int db = 0;

foreach (string szo in szavak)
{
    if (szo.Length > 0 && szo.ToLower()[0] == 'b')
    {
        db++;
    }
}

Console.WriteLine($"{db}db ilyen szó van a listában");