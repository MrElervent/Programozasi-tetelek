string mondat = "A fekete macska alszik.";

int db = 0;

char[] betu = ['e', 'E'];

foreach (char c in mondat)
{
    if (betu.Contains(c))
    {
        db++;
    }
}

Console.WriteLine($"A mondatban {db} 'e' betű van");