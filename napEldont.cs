string[] napok = ["hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap"];

Console.Write("kérem adjon meg egy szót: ");
string adottSzo = Console.ReadLine();

bool talalat = false;

for(int i = 0; i < napok.Length; i++)
{
    if(napok[i] == adottSzo)
    {
        talalat = true;
    }
}

if(talalat == true)
{
    Console.WriteLine("\nAz adott szó egy nap neve");
}
else
{
    Console.WriteLine("\nAz adott szó NEM egy nap neve");
}