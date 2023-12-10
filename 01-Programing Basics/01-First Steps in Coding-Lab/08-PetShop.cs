int dogFoodPackets = int.Parse(Console.ReadLine());
int catFoodPackets = int.Parse(Console.ReadLine());

double priceDogFood = dogFoodPackets * 2.50;
int priceCatFood = catFoodPackets * 4;

double totalFoodPrice = priceDogFood + priceCatFood;

Console.WriteLine($"{totalFoodPrice} lv.");