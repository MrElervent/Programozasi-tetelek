int[] jegyek = [4, 5, 5, 4, 3, 2, 2, 4, 3, 5];

int index = 0;

while(index < jegyek.Length && jegyek[index] != 5)
{
    index++;
}

if(index < jegyek.Length)
{
    Console.WriteLine($"A {index+1}. dolgozat ötös lett");
}
else
{
    Console.WriteLine("Nem volt ötös dolgozat");
}