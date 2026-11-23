int indulas = 7;

int[] erkezesH = [8,  8, 8,  7,  8,  8,  8 ];
int[] erkezesM = [10, 2, 30, 52, 33, 14, 12];

int gyoztes = 0;
int gyoztesIdo = 100000;

for(int i = 0; i < erkezesH.Length; i++)
{
    int start = indulas * 60;
    int end = erkezesH[i] * 60 + erkezesM[i];
    int futamido = end - start;
    if(futamido < gyoztesIdo)
    {
        gyoztes = i;
        gyoztesIdo = futamido;
    }
}

Console.WriteLine($"a {gyoztes+1}. versenyző a győztes, futamideje: {gyoztesIdo} perc");