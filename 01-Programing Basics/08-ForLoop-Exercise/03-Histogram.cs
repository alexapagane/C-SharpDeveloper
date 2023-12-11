int n = int.Parse(Console.ReadLine());

//int c1 = 0; c2 = 0; c3 = 0; c4 = 0; c5 = 0;
int c1 = 0; 
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber < 200)
    {
        c1++;
    }
    else if(currentNumber < 400)
    {
        c2++;
    }
    else if (currentNumber < 600)
    {
        c3++;
    }
    else if( currentNumber < 800)
    {
        c4++;
    }
    else 
    { 
        c5++;
    }
    
}
    double p1 = (double) c1 / n * 100;
    double p2 = (double) c2 / n * 100;
    double p3 = (double) c3 / n * 100;
    double p4 = (double) c4 / n * 100;   
    double p5 = (double) c5 / n * 100;

Console.WriteLine($"{p1:F2}%");
Console.WriteLine($"{p2:F2}%");
Console.WriteLine($"{p3:F2}%");
Console.WriteLine($"{p4:F2}%");
Console.WriteLine($"{p5:F2}%");