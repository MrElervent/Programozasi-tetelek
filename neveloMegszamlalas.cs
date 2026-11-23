string szoveg = "Isten, áldd meg a magyart Jó kedvvel, bőséggel, Nyújts feléje védő kart, Ha küzd ellenséggel; Bal sors akit régen tép, Hozz rá víg esztendőt, Megbűnhődte már e nép A múltat s jövendőt!";

int db = 0;

for(int i = 0; i < szoveg.Length; i++)
{
    char c = char.ToLower(szoveg[i]);

    if(c == 'a' && szoveg[i-1] == ' ' && szoveg[i + 1] == ' ')
    {
        db++;
    }
}

Console.WriteLine($"A megadott szövegben {db}db 'a' névelő van");