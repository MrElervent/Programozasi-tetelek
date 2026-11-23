Console.Write("Adjon meg egy számot: ");
int szam = Convert.ToInt32(Console.ReadLine());

int fakotrialis = 1;
for(int i = 1; i <= szam; i++)
{
    fakotrialis = fakotrialis * i;
}

Console.WriteLine(fakotrialis);