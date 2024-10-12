int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] liczba = input.Split(' ');

    int podstawa = int.Parse(liczba[0]);
    podstawa = podstawa % 10;
    int wykladnik = int.Parse(liczba[1]);
    if (wykladnik > 0)
    {
        if (wykladnik % 4 == 0)
        {
            wykladnik = 4;
        }
        else
        {
            wykladnik = wykladnik % 4;
        }

        int wynik = podstawa;

        for (int j = 1; j < wykladnik; j++)
        {
            wynik *= podstawa;
        }
        Console.WriteLine(wynik % 10);
    }
    else
    {
        Console.WriteLine(1);
    }
}
