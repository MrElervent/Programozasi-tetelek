int[] bevetel = {650000, 650000, 680000, 650000, 720000, 650000, 700000, 680000, 660000, 660000, 680000, 850000};

int[] kiadas = {580000, 610000, 540000, 590000, 510000, 670000, 740000, 620000, 570000, 550000, 600000, 790000};

int max = 0;

for(int i = 0; i < 12; i++)
{
    if ((bevetel[i] -  kiadas[i]) > (bevetel[max] - kiadas[max]))
    {
        max = i;
    }
}

Console.WriteLine($"a {max+1}. hónapban tudtak a legtöbbet megtakarítani: {bevetel[max] - kiadas[max]}");