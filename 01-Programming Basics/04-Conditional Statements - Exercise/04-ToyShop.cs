double puzzlePrice = 2.60;
double talkingDollPrice = 3.00;
double bearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2.00;

double priceOfTrip = double.Parse(Console.ReadLine());
double puzzleNumber = double.Parse(Console.ReadLine());
double talkingDollNumber = double.Parse(Console.ReadLine());
double bearNumber = double.Parse(Console.ReadLine());
double minionNumber = double.Parse(Console.ReadLine());
double truckNumber = double.Parse(Console.ReadLine());

double totalSum = puzzlePrice *puzzleNumber + talkingDollPrice *talkingDollNumber + bearPrice *bearNumber + minionPrice *minionNumber +truckPrice * truckNumber;
double numberOfToys = puzzleNumber + talkingDollNumber + bearNumber + minionNumber + truckNumber;

if(numberOfToys >= 50)
{
//discount 25% for over 50 toys
    totalSum *= 0.75;
}
//rent out 10% of totalSum
totalSum *= 0.9;

if(totalSum >= priceOfTrip)
{
 totalSum -= priceOfTrip;
    Console.WriteLine($"Yes! {totalSum:F2} lv left.");
}
else
{
 priceOfTrip-= totalSum;
    Console.WriteLine($"Not enough money! {priceOfTrip:F2} lv needed.");
}