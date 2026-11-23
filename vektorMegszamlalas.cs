int[] vektor = [2, 2, 5, 8, 8, 8, 12, 19, 19];
List<int> db = new List<int>();

for(int i = 0;i< vektor.Length; i++)
{
    if(db.Count != 0)
    {
        if (!db.Contains(vektor[i]))
        {
            db.Add(vektor[i]);
        }
    }
    else
    {
        db.Add(vektor[i]);
    }
    
}

Console.WriteLine($"{db.Count}db különböző érték van a vektor tömbben");