int plastic = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int solvent = int.Parse(Console.ReadLine());
int totalHoursWork = int.Parse(Console.ReadLine());

double plasticPrice = (plastic + 2) * 1.50;
double paintPrice = (paint + paint * 0.1) * 14.50;
double solventPrice = (solvent * 5.00);
double priceOfBags = 0.40;

double totalPrice = plasticPrice + paintPrice + solventPrice + priceOfBags;

double priceForWorkers = (totalPrice * 0.3) * totalHoursWork;

double finalPrice = totalPrice + priceForWorkers;

Console.WriteLine($"{finalPrice}");