int n = int.Parse(Console.ReadLine());

//int c1 = 0; c2 = 0; c3 = 0; c4 = 0; c5 = 0;
int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;

double climbersCount = 0;
for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber <= 5)
    {
        c1+=currentNumber;
    }
    else if (currentNumber <= 12)
    {
        c2 += currentNumber;
    }
    else if (currentNumber <= 25)
    {
        c3 += currentNumber;
    }
    else if (currentNumber <= 40)
    {
        c4 += currentNumber;
    }
    else
    {
        c5 += currentNumber;
    }
    climbersCount += currentNumber;
}
double p1 = (double)c1 / climbersCount * 100;
double p2 = (double)c2 / climbersCount * 100;
double p3 = (double)c3 / climbersCount * 100;
double p4 = (double)c4 / climbersCount * 100;
double p5 = (double)c5 / climbersCount * 100;

Console.WriteLine($"{p1:F2}%");
Console.WriteLine($"{p2:F2}%");
Console.WriteLine($"{p3:F2}%");
Console.WriteLine($"{p4:F2}%");
Console.WriteLine($"{p5:F2}%");