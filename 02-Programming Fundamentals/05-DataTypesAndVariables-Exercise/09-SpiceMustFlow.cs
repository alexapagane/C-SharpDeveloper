int startingYield = int.Parse(Console.ReadLine());

int daysCounter = 0;
int workersConsume = 0;
int totalAmount = 0;

while (startingYield >= 100)
{
    daysCounter++;
    workersConsume = startingYield - 26;
    totalAmount += workersConsume;
    startingYield = startingYield - 10;
}

if (totalAmount >= 26)
{
    totalAmount = totalAmount - 26;
}

Console.WriteLine(daysCounter);
Console.WriteLine(totalAmount);

