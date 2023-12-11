double chickenMenu = 10.35;
double fishMenu = 12.40;
double vegetarianMenu = 8.15;

int chickenMenuNumber = int.Parse(Console.ReadLine());
int fishMenuNumber = int.Parse(Console.ReadLine());
int vegetarianMenuNumber = int.Parse(Console.ReadLine());

double priceChickenMenu = chickenMenu * chickenMenuNumber;
double priceFishMenu = fishMenu * fishMenuNumber;
double priceVegetarianMenu = vegetarianMenu * vegetarianMenuNumber;
double priceTotal = priceChickenMenu + priceFishMenu + priceVegetarianMenu;
double priceDesert = priceTotal * 20 / 100;
double priceDelivery = 2.50;

double priceFinal = priceTotal + priceDesert + priceDelivery;

Console.WriteLine($"{priceFinal}");