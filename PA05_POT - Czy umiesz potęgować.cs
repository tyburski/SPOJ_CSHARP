int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] liczba = input.Split(' ');

    int wynik = int.Parse(liczba[0]);
    int podstawa = int.Parse(liczba[0]);
    int wykladnik = int.Parse(liczba[1]);
    if(wykladnik > 0)
    {
        if (wykladnik % 4 == 0)
        {
            wykladnik = 4;
        }
        else wykladnik = wykladnik % 4;

        for (int j = 1; j < wykladnik; j++)
        {
            wynik *= podstawa;
        }
        string wynikString = wynik.ToString();
        char jednosci = wynikString[wynikString.Length - 1];
        Console.WriteLine(jednosci);
    }
    else Console.WriteLine(1);
}

