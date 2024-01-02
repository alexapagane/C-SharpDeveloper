int ordersN = int.Parse(Console.ReadLine());
double pricePerCapsule = double.Parse(Console.ReadLine());
int daysInMonth = int.Parse(Console.ReadLine());
int capsulesCount = int.Parse(Console.ReadLine());

double totalPrice = 0;

for (int i = 1; i <= ordersN; i++)
{
    totalPrice += ((daysInMonth * capsulesCount) * pricePerCapsule);
    double price = (daysInMonth * capsulesCount) * pricePerCapsule;
    Console.WriteLine($"The price for the coffee is: ${price:F2}");
    if(i == ordersN)
    {
        break;
    }
    pricePerCapsule = double.Parse(Console.ReadLine());
    daysInMonth = int.Parse(Console.ReadLine());
    capsulesCount = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Total: ${totalPrice:F2}");