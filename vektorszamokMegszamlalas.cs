int[] vektor = [-5, 4, -2, 0, -7, 3, -1, 0, -9, 6];

int nulla = 0;
int pozitiv = 0;
int negativ = 0;

for(int i = 0; i < vektor.Length; i++)
{
    if (vektor[i] < 0)
    {
        negativ++;
    }
    else if (vektor[i] > 0)
    {
        pozitiv++;
    }
    else
    {
        nulla++;
    }
}
Console.WriteLine($"A vektorban {negativ}db negatív, {nulla} db nulla és {pozitiv}db pozitív szám van.");