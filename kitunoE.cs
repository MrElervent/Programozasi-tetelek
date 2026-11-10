using System.Globalization;

int[] evVegiJegy = [5, 5, 5, 5];
int[] evVegiJegy2 = [5, 5, 5, 4];

bool kitunoe = false;

for(int i = 0;  i < evVegiJegy.Length; i++)
{
    if (evVegiJegy[i] != 5)
    {
        kitunoe = false;
    }
    else
    {
        kitunoe = true;
    }
}
if(kitunoe == true)
{
    Console.WriteLine($"1. tanuló kituno volt év végén");
}
else
{
    Console.WriteLine($"1. tanuló nem volt kitűnő év végén");
}

for (int i = 0; i < evVegiJegy2.Length; i++)
{
    if (evVegiJegy2[i] != 5)
    {
        kitunoe = false;
    }
    else
    {
        kitunoe = true;
    }
}

if (kitunoe == true)
{
    Console.WriteLine($"2. tanuló kituno volt év végén");
}
else
{
    Console.WriteLine($"2. tanuló nem volt kitűnő év végén");
}