string input = Console.ReadLine();

double bankAccount = 0;

while (input != "NoMoreMoney")
{
    double amountOfMoney = double.Parse(input);
    if (amountOfMoney < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {amountOfMoney:F2}");
    bankAccount += amountOfMoney;
    
    input = Console.ReadLine();
}
Console.WriteLine($"Total: {bankAccount:F2}");