double recordInSeconds = double.Parse(Console.ReadLine());  
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecPerMeter = double.Parse(Console.ReadLine());

double timeInSeconds = distanceInMeters * timeInSecPerMeter;

int delays = (int)Math.Floor(distanceInMeters / 15);

double delaysInSeconds = delays * 12.5;

double totalTimeInSeconds = timeInSeconds + delaysInSeconds;

if(totalTimeInSeconds < recordInSeconds)
{
    
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeInSeconds:F2} seconds.");
}
else
{ 
    double difference =  totalTimeInSeconds - recordInSeconds;
    Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
}