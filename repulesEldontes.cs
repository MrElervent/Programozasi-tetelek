int[] magassag = [1, 5, 10, 15, 18, 18, 0, 0, 1, 2, 2, 0, 0, 0, 16, 13, 10, 6, 2, 11];

bool sz = false;
bool t = false;

for(int i = 0; i < magassag.Length; i++)
{
    if (magassag[i] == 0)
    {
        t = true;

        if (i > 0 && t == true && (magassag[i-1] > 0 && magassag[i] == 0))
        {
            sz = true;
        }
    }
}

if(t == true)
{
    Console.WriteLine("Jártunk a tenger felett");
}
else
{
    Console.WriteLine("Nem jártunk a tenger felett");
}
if(sz == true)
{
    Console.WriteLine("Átrepültünk egy sziget felett");
}
else
{
    Console.WriteLine("Nem repültünk át egy sziget fölött");
}