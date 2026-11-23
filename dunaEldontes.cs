List<double> homerseklet = [8.2, 8.5, 8.9, 9.1, 9.4, 9.8, 10.0, 10.3, 10.1, 10.6, 11.0, 11.2, 11.5, 11.8, 12.0,
                        12.3, 12.7, 13.0, 13.2, 13.5, 13.8, 14.1, 14.4, 14.6, 14.9, 15.2, 15.5, 15.8, 16.0, 16.3];

bool emelkedette= true;

for (int i = 1; i < homerseklet.Count; i++)
{
    if (homerseklet[i] <= homerseklet[i - 1])
    {
        emelkedette = true;
    }
    else
    {
        emelkedette = false;
    }
}

if (emelkedette == true)
{
    Console.WriteLine("Folyamatosan emelkedett a Duna hőmérséklete");
}
else
{
    Console.WriteLine("Nem emelkedett folyamatosan a Duna hőmérséklete");
}