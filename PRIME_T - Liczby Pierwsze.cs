List<int> inputList = new List<int>();
int input = Convert.ToInt32(Console.ReadLine());
int n = input;
for(int i = 0; i < n; i++)
{
    input = Convert.ToInt32(Console.ReadLine());
    inputList.Add(input);
    //input = Convert.ToInt32(Console.ReadLine());
}
foreach(var i in inputList)
{
    if(i == 1) Console.WriteLine("NIE");
    if(i == 2) Console.WriteLine("TAK");

    if(i > 2)
    {
        var c = true;
        for (int j = i-1; j > 1; j--)
        {
            if (i % j == 0)
            {
                c = false;
            }
        }
        if (c) Console.WriteLine("TAK");
        else Console.WriteLine("NIE");
    }   
}
