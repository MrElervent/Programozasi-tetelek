int[] evszamok = [1526, 895, 1920, 1956, 1989, 2004, 1000, 1241, 1222, 1301];

int keresett = 1222;
int sorszam = 0;

for(int i =0; i< evszamok.Length; i++)
{
    if(keresett == evszamok[i])
    {
        sorszam = i + 1;
    }
}

Console.WriteLine($"Az aranybulla kiadásának évszáma a {sorszam}. a tömbben");