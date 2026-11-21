int[] homerseklet = [24, 22, 23, 23, 22, 20, 21, 21, 20, 18, 19, 19, 18, 18, 17, 17, 17, 16, 16, 15, 15, 15, 14, 14, 14, 13, 13, 13, 13, 13];

int index = 1;
bool monotonCS = false;

for(int i = 0; i<homerseklet.Length; i++)
{
    if (homerseklet[i] > homerseklet[index])
    {
        index++;
        monotonCS = true;
    }
}

if(monotonCS == true)
{
    Console.WriteLine("A megmért hőmérsékletek alapján Szeptemberben monoton fogyó.");
}
else
{
    Console.WriteLine("A megmért hőmérsékletek alapján Szeptemberben nem monoton fogyó.");
}