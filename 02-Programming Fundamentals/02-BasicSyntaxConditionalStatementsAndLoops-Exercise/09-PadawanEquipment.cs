double  amountOfMoney = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());    
double priceOfLightSabers = double.Parse(Console.ReadLine());
double priceOfRobes = double.Parse(Console.ReadLine());
double priceOfBelts = double.Parse(Console.ReadLine());

double priceForAllLightSabers = Math.Ceiling(countOfStudents * 1.1) * priceOfLightSabers;
double priceForAllRobes = countOfStudents * priceOfRobes;

int freeBelts = countOfStudents / 6;

double priceForAllBelts = (countOfStudents - freeBelts) * priceOfBelts;

double finalPrice = priceForAllBelts + priceForAllLightSabers + priceForAllRobes;

if (finalPrice <= amountOfMoney)
{
    Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
}
else
{
    double neededMoney = finalPrice - amountOfMoney;
    Console.WriteLine($"John will need {neededMoney:f2}lv more.");
}