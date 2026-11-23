int[] szamsorozat = [2, 5, 6, 100, 77, 82, 51, 43];

int max = 0;
int min = 0;

for(int i = 0;i < szamsorozat.Length; i++)
{
    if (szamsorozat[i] > szamsorozat[max])
    {
        max = i;
    }
    if (szamsorozat[i] < szamsorozat[min])
    {
        min = i;
    }
}

Console.WriteLine($"A tetszőleges számsorozat legkisebb száma: {szamsorozat[min]} és legnagyobb száma: {szamsorozat[max]}");