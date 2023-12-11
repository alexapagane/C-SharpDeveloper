int priceBasketballTrainingYear = int.Parse(Console.ReadLine());

double priceSnikers = priceBasketballTrainingYear * 0.6;
double priceTracksuit = priceSnikers * 0.8;
double priceBsketball = priceTracksuit * 0.25;
double priceAccessories = priceBsketball * 0.2;

double priceTotal = priceBasketballTrainingYear + priceSnikers + priceTracksuit + priceBsketball + priceAccessories;

Console.WriteLine(priceTotal);