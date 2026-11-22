int[] idomeres = [100, 105, 88, 150, 104, 90, 91, 111, 121, 89, 117, 101];

int otos = 100;
double db = 0;

for(int i = 0; i < idomeres.Length; i++)
{
    if(idomeres[i] <= otos)
    {
        db++;
    }
}

if (db == 0)
{
    Console.WriteLine("Nincs olyan diák aki elérte volna az 5-ös szintet");
}
else
{
    Console.WriteLine($"A diákok {(db / idomeres.Length)*100:0.00}%-a teljesítette az 5-ös szintet");
}