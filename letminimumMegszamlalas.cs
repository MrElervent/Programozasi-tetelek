int[] csalad = { 2, 2, 3, 4, 2, 5, 3, 3, 4, 2 };
int[] jovedelem = { 340000, 260000, 480000, 520000, 300000, 600000, 390000, 690000, 880000, 280000 };

int letminimum = 150000;
int jovedelemEgyFore;
int db = 0;

for(int i = 0; i <  csalad.Length; i++)
{
    jovedelemEgyFore = jovedelem[i] / csalad[i];
    if(jovedelemEgyFore < letminimum)
    {
        db++;
    }
}

Console.WriteLine($"{db}db család él a létminimum alatt({letminimum}Ft alatt)");