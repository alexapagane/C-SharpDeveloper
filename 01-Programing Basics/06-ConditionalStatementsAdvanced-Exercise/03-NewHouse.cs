string flowerType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());   
int budget = int.Parse(Console.ReadLine());

double totalPrice = 0;

switch (flowerType)
{
    case "Roses":
        totalPrice = flowersCount * 5;
        if (flowersCount > 80)
        {
            totalPrice -= totalPrice * 0.1;
        }
        break;
    case "Dahlias":
        totalPrice = flowersCount * 3.80;
        if (flowersCount > 90)
        {
            totalPrice -= totalPrice * 0.15;
        }
        break;
    case "Tulips":
        totalPrice = flowersCount * 2.80;
        if(flowersCount > 80)
        {
            totalPrice -= totalPrice * 0.15;
        }
        break;
    case "Narcissus":
        totalPrice = flowersCount * 3;
        if(flowersCount < 120)
        {
            totalPrice += totalPrice * 0.15;
        }
        break;
    case "Gladiolus":
        totalPrice = flowersCount * 2.50;
        if (flowersCount < 80)
        {
            totalPrice += totalPrice * 0.20;
        }
        break;
    default:
        break;
}
if (totalPrice <= budget)
{
    double remainingBudget = budget - totalPrice;
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {remainingBudget:F2} leva left.");
}
else
{
    double neededMoney = totalPrice - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
}