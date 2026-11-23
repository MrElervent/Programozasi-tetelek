double[] dunavize = [6.4, 7.1, 8.3, 8.9, 9.2, 8.7, 7.9, 6.8, 6.2, 5.9, 6.5, 7.4];

int index = 0;
while(index < dunavize.Length && dunavize[index] != 9.2)
{
    index++;
}

if(index < dunavize.Length)
{
    Console.WriteLine("Volt 9.2 méteres mérés");
}
else
{
    Console.WriteLine("Nem volt 9.2 méteres mérés");
}