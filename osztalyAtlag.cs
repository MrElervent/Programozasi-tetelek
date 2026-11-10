using System.Buffers;
using System.Globalization;

int[] osztalyAtlag = [4,5,5,4,3,2,2,4,3,5];
int osszeg = 0;

for(int i  = 0; i< osztalyAtlag.Length; i++)
{
    osszeg += osztalyAtlag[i];
}

double atlag = Convert.ToDouble(osszeg) / osztalyAtlag.Length;

Console.WriteLine($"Az osztály átlaga: {atlag}");