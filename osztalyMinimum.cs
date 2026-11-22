int[] osztaly = [155, 156, 190, 177, 172, 182, 186, 187, 154, 167];

int min = 0;

for(int i = 0;i  < osztaly.Length; i++)
{
    if(osztaly[i] < osztaly[min])
    {
        min = i;
    }
}

Console.WriteLine($"{osztaly[min]}cm a legalacsonyabb diák az osztályban");