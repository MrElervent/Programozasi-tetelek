int[] magassag = [1420, 2785, 1950, 2310, 1180, 2910, 1670];

int max = 0;

for(int i = 0; i < magassag.Length; i++)
{
    if(magassag[i] > magassag[max])
    {
        max = i;
    }
}

Console.WriteLine($"A legmagasabb hegy: {magassag[max]}m magas");