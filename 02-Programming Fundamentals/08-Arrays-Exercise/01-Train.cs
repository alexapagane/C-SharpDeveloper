int arraySize = int.Parse(Console.ReadLine());
int sumOfPassengers = 0;
int[] passengersInWagon = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    int passengers = int.Parse(Console.ReadLine());
    passengersInWagon[i] = passengers;
    sumOfPassengers += passengersInWagon[i];
}
Console.WriteLine(string.Join(" ", passengersInWagon));
Console.WriteLine(sumOfPassengers);