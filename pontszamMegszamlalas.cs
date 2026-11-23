int[] pontszam = [45, 78, 14, 92, 63, 19, 84, 51, 8, 70, 36, 95, 17, 68, 82, 11, 59, 74, 20, 88, 42, 6, 91, 55, 77];

int db = 0;

for(int i = 0; i < pontszam.Length; i++)
{
    if (pontszam[i] < 20)
    {
        db++;
    }
}

Console.WriteLine($"{db} db kutya esett ki az első fordulóból");