int input = int.Parse(Console.ReadLine());
for (int i = 2; i <= input; i++)
{
    bool isTrue = true;
    for (int cepitel = 2; cepitel < i; cepitel++)
    {
        if (i % cepitel == 0)
        {
            isTrue = false;
            break;
        }
    }
    if (!isTrue)
    {
       Console.WriteLine($"{i} -> false");
    }
    else
    {
        Console.WriteLine($"{i} -> true");
    }
   
}