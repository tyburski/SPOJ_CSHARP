int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    if(input < 10)
    {
        int c = 1;
        for (int j = 1; j <= input; j++)
        {
            c *= j;
        }
        int dziesiatki = (c / 10) % 10;
        int jednosci = c % 10;
        Console.WriteLine($"{dziesiatki} {jednosci}");
    }
    else
    {
        Console.WriteLine("0 0");
    }


}

