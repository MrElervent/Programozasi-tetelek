string[] veradomany = [ "Kovács Anna", "Szabó Gábor", "Nagy Péter", "Tóth Eszter", "Kovács József", "Horváth Dóra", "Varga Bence", "Molnár Zsófia", "Farkas Tamás", "Balogh Lilla" ];

int i = 0;
while(i < veradomany.Length && veradomany[i] == "Nagy József")
{
    i++;
}

if(i < veradomany.Length)
{
    Console.WriteLine("Nagy József vért adott");
}
else
{
    Console.WriteLine("Nagy József nincs a véradók között");
}