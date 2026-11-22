double[] erkezesek = [6.50, 6.58, 7.12, 7.25, 7.40, 8.00];

int index = 0;

for(int i = 0; i< erkezesek.Length; i++)
{
    if (erkezesek[i]>7.30 && erkezesek[i] < 7.45)
    {
        index = i;
    }
}

Console.WriteLine($"Érkezési időpont 1/2 8 és 3/4 8 között: {erkezesek[index]}");