string[] konyvtar = ["Pál utcai fiúk", "Egri csillagok", "Szent Péter esernyője", "Az aranyember", "A köpönyeg", "Romeo és Júlia"];

int i = 0;
while(i < konyvtar.Length &&  konyvtar[i] != "Egri csillagok")
{
    i++;
}

if(i < konyvtar.Length)
{
    Console.WriteLine("Az 'Egri csillagok' c. könyv bent van ");
}
else
{
    Console.WriteLine("Az 'Egri csillagok' c. könyv nincs bent");
}