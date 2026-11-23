string szoveg = " A reggeli csengő megszólalása után a diákok gyorsan elfoglalták a helyüket a tanteremben. A tanár izgalmas kísérlettel mutatta be a fizika alapjait, miközben mindenki figyelmesen jegyzetelt. A szünetben pedig a folyosón beszélgették meg a legújabb élményeket és a házi feladatot. ";

int mondatdb = 0;
int szodb = 0;

for(int i = 0; i < szoveg.Length; i++)
{
    char c = char.ToLower(szoveg[i]);

    if(c == ' ')
    {
        szodb++;
    }

    else if(c == '.' || c == '!' || c == '?')
    {
        mondatdb++;
        Console.WriteLine($"{mondatdb}. mondatban {szodb}db szó van");
        szodb = 0;
    }
}

Console.WriteLine($"A megadott szövegben {mondatdb} mondat van");