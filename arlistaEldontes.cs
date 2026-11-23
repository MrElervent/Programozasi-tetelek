int[] arlista = [85000, 42900, 18500, 129900, 64000, 15900, 215000, 34500, 98000, 52000];

int index = 0;
while(index < arlista.Length && arlista[index] !<= 20000)
{
    index++;
}

if(index < arlista.Length)
{
    Console.WriteLine("Van 20000Ft-nál olcsóbb");
}
else
{
    Console.WriteLine("Nincs 20000Ft-nál olcsóbb");
}