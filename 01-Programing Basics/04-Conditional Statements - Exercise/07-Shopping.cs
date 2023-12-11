double graphicsCardPrice = 250.00;

double budget = double.Parse(Console.ReadLine());
double graphicsCardNum = double.Parse(Console.ReadLine());
double processorNum = double.Parse(Console.ReadLine());
double ramMemoryNum = double.Parse(Console.ReadLine());

double sumGraphicsCards = graphicsCardNum * graphicsCardPrice;

double processorPrice = sumGraphicsCards * 0.35;
double sumProcessor = processorNum * processorPrice;

double ramMemoryPrice = sumGraphicsCards * 0.1;
double sumRamMemory = ramMemoryNum * ramMemoryPrice;

double totalSum = sumGraphicsCards + sumProcessor + sumRamMemory;
if(graphicsCardNum > processorNum)
{
    totalSum *= 0.85;
}
if(totalSum <= budget)
{ 
    double difference = budget - totalSum;
    Console.WriteLine($"You have {difference:F2} leva left!");
}
else
{
    double difference = totalSum - budget;
    Console.WriteLine($"Not enough money! You need {difference:F2} leva more!");
}