int[] vektor = [-5, 4, -2, 0, -7, 3, -1, 0, -9, 6];

int i = 0;
while (i < vektor.Length&& vektor[i] != 0)
{
    i++;
}

int db = 0;
for(int j = i+1; j<vektor.Length; j++)
{
    if (vektor[j] < 0)
    {
        db++;
    }
}

if(i < vektor.Length)
{
    Console.WriteLine($"Az első 0 után {db} negatív elem van");
}
else
{
    Console.WriteLine("Nincs nulla a tömbben");
}