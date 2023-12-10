double squareMetersGreening =double.Parse(Console.ReadLine());

double totalPrice = squareMetersGreening * 7.61;
double discount = totalPrice * 0.18;

double finalPriceWithDiscount = totalPrice - discount;

Console.WriteLine($"The final price is: {finalPriceWithDiscount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");