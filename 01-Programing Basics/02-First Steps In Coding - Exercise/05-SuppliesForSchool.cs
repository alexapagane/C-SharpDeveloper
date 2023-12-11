int pens = int.Parse(Console.ReadLine());
int markerPens = int.Parse(Console.ReadLine());
int solvent = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double priceOfPens = pens * 5.80;
double priceOfMarkerPens = markerPens * 7.20;
double priceOfSolvent = solvent * 1.20;
double totalPrice = priceOfPens + priceOfMarkerPens + priceOfSolvent;
double totalDiscount = totalPrice - (totalPrice * discount / 100);

Console.WriteLine(totalDiscount);