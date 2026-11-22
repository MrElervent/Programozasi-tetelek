double[] szamsor = [10, 3, 44, -8, 8, 19, -2];

bool vane = false;

for(int i = 0; i< szamsor.Length; i++)
{
    if (szamsor[i] < -5)
    {
        vane = true;
    }
}

if(vane == true)
{
    Console.WriteLine("A számsornak van -5-nél kisebb eleme");
}
else
{
    Console.WriteLine("A számrosnak nincs -5-nél kisebb eleme");
}