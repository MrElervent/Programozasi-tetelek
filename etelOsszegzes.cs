//   alapanyagok   "liszt(dkg)", "tej(l)", "tojás(db)", "cukor(evk)", "étolaj(evk)"
double[] mennyiseg = [30,           0.5,        2,          1,              0.5 ];
int[] egysegar =  [ 300, 450, 90, 500, 800 ];

double ossz = 0;

for(int i = 0; i < mennyiseg.Length; i++)
{
    ossz += mennyiseg[i] * egysegar[i];
}

Console.WriteLine($"Az étel teljes nyersanyagköltsége: {ossz}Ft");