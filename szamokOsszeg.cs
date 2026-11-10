int[] szamok = [1,2,3,4,5,6,7,8,9,10];
int osszeg = 0;

for(int i = 0; i< szamok.Length; i++)
{
    osszeg += szamok[i];
}

Console.WriteLine(osszeg);