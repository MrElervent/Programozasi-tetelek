double[] folyoM = [3.3, 5.4, 6, 6.7, 9.2, 13, 26, 22.2, 17.6, 14, 12, 13, 9.8, 5, 3.3];

int max = 0;

for(int i = 0; i < folyoM.Length; i++)
{
    if (folyoM[i] > folyoM[max])
    {
        max = i;
    }
}

Console.WriteLine($"A folyó legmélyebb pontja: {folyoM[max]}m");