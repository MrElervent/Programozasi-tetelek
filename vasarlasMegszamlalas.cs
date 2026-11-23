int[] fizetett = [2450, 7890, 1200, 5600, 3400, 12500, 990, 4350, 8900, 1850, 4120, 9450, 3890, 850, 6300, 4990, 
                  7100, 2780, 11300, 1560, 3600, 5490, 1950, 14200, 4890, 8150, 2300, 3990, 1450, 4700];


int db = 0;

for(int i = 0; i < fizetett.Length; i++)
{
    if (fizetett[i] > 5000)
    {
        db++;
    }
}

Console.WriteLine($"A múlt hónapban {db} alkalommal vásároltam 5000Ft felett");