int[] szamsorozat = [7, 42, 105, 8920, 3, 99, 614, 1234, 5412, 18, 750, 2026];

int db1 = 0;
int db2 = 0;
int db3 = 0;
int db4 = 0;

for(int i = 0; i < szamsorozat.Length; i++)
{
    if (szamsorozat[i] < 10)
    {
        db1++;
    }
    else if (szamsorozat[i] < 100)
    {
        db2++;
    }
    else if (szamsorozat[i] < 1000)
    {
        db3++;
    }
    else if (szamsorozat[i] < 10000)
    {
        db4++;
    }
}

Console.WriteLine($"A számsorozatban: \n\t{db1}db egyjegyű szám van, \n\t{db2}db kétjegyű szám van, \n\t{db3}db háromjegyű szám van, \n\t{db4}db négygyjegyű szám van.");