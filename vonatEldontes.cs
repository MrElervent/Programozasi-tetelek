int osszesHely = 8;
int[] kiadottHelyjegyek = [1, 2, 3, 5, 7, 8]; 

int db = 0;

for (int i = 0; i < kiadottHelyjegyek.Length; i++)
{
    db++;
}

int szabadhely = osszesHely - db;

if (szabadhely > 0)
{
    Console.WriteLine($"Van még szabad hely a vonaton ({szabadhely} db).");
}
else
{
    Console.WriteLine("Nincs már szabad hely a vonaton.");
}