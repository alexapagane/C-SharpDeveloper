int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustion = int.Parse(Console.ReadLine());
int targets = 0;
int leftPower = power;
while (leftPower >= distance)
    {
     leftPower -= distance;
     targets++;
     if (leftPower == 0.50 * power && exhaustion != 0)
     {
                 
           leftPower /= exhaustion;
                   
     }
           }
Console.WriteLine(leftPower);
Console.WriteLine(targets);