double[] tomb = {-12, -8, 2, -2, -3, 4, 2, -2, 6, 3, 1, -5};

int db = 0;
for(int i = 0;i < tomb.Length; i++)
{
    if(tomb[i] < 0)
    {
        db++;
    }
}

Console.WriteLine($"{db} alkalommal mértek fagypont alatt");