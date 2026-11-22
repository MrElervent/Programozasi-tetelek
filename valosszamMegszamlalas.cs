double[] valosSZ = { 2.04, 17.41, -0.64, 1.62, 16.22, -0.92, 15.33, -7.65, -6.62, 13.41, 13.57, -2.34, 9.42, 0.94, -2.78 };

Console.Write("Kérem adjon meg egy valós számot: ");
double megadott = Convert.ToDouble(Console.ReadLine());

int db = 0;

for(int i = 0; i < valosSZ.Length; i++)
{
    if(valosSZ[i] < megadott)
    {
        db++;
    }
}
if(db == 0)
{
    Console.WriteLine("Nincs olyan valós szám ami kisebb lenne a megadott számnál");
}
else
{
    Console.WriteLine($"{db}db valós szám van ami kisebb a megadott számnál");
}