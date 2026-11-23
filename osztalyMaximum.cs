string[] osztaly = ["Kiss Anna", "Nagy Bence", "Tóth Eszter", "Szabó Kristóf", "Kovács Lili", "Horváth Dominik", 
    "Varga Petra", "Molnár Zsombor", "Farkas Boglárka", "Balogh Ádám", "Papp Vivien", "Takács Benedek"];

int max = 0;
int hossz = 0;

for(int i = 0; i < osztaly.Length; i++)
{
    if (osztaly[i].Length > osztaly[max].Length)
    {
        max = i;
        hossz = osztaly[i].Length;
    }
}

Console.WriteLine($"A leghosszabb név: {osztaly[max]}, {hossz-1}db karakter");