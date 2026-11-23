string[] szosorozat = ["alma", "körte", "banán", "szilva", "szőlő", "cékla", "paradicsom", "répa"];

int magas = 0;
int mely = 0;
int vegyes = 0;

char[] melyHangok = ['a', 'á', 'o', 'ó', 'u', 'ú', 'A', 'Á', 'O', 'Ó', 'U', 'Ú'];
char[] magasHangok = ['e', 'é', 'i', 'í', 'ö', 'ő', 'ü', 'ű', 'E', 'É', 'I', 'Í', 'Ö', 'Ő', 'Ü', 'Ű'];

for (int i = 0; i < szosorozat.Length; i++)
{
    string szo = szosorozat[i];
    bool vanMely = false;
    bool vanMagas = false;

    for (int j = 0; j < szo.Length; j++)
    {
        char ch = szo[j];

        if (melyHangok.Contains(ch))
        {
            vanMely = true;
        }
        else if (magasHangok.Contains(ch))
        {
            vanMagas = true;
        }
    }

    if (vanMely && vanMagas)
    {
        vegyes++;
    }
    else if (vanMagas)
    {
        magas++;
    }
    else if (vanMely)
    {
        mely++;
    }
}

Console.WriteLine($"Magas hangrendű: {magas}db");
Console.WriteLine($"Mély hangrendű: {mely}db");
Console.WriteLine($"Vegyes hangrendű: {vegyes}db");