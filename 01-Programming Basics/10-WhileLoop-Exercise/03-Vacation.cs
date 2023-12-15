double neededMoney = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int daysCounter = 0;
int spendCounter = 0;

while(availableMoney < neededMoney)
{
    string input = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());

    daysCounter++;

    if(input == "spend")
    {
        spendCounter++;
        if (spendCounter == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysCounter);
            break;
        }
        availableMoney -= money;
        if (availableMoney < 0)
        {
            availableMoney = 0;
        }
    }
    else
    {
        spendCounter = 0;
        availableMoney += money;
    }
}
if (availableMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}