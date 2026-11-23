Random rnd = new Random();
List<int> lotto = new List<int>();


int generaltSZ = 0;
while(lotto.Count < 7)
{
    generaltSZ = rnd.Next(1, 100);

    if (!lotto.Contains(generaltSZ)){
        lotto.Add(generaltSZ);
    }
}

Console.WriteLine("Húzott számok: ");
bool vane = false;
for(int i = 0;i < lotto.Count; i++)
{
    Console.Write($"{lotto[i]}, ");
    if (lotto[i] == 55)
    {
        vane = true;
    }
}

if(vane != true)
{
    Console.WriteLine("\nNem húzták ki az 55-öst");
}
else
{
    Console.WriteLine("\nKihúzták az 55-öst");
}