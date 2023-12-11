string nameOfSeries = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());    
int breakDuration = int.Parse(Console.ReadLine());

double lunchTime = breakDuration * 1.0 / 8;
double restTime = breakDuration * 1.0 / 4;

double remaningTime = breakDuration -lunchTime - restTime;

if(remaningTime >= episodeDuration)
{   
    int difference = (int)Math.Ceiling(remaningTime - episodeDuration);
    Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {difference} minutes free time.");
}
else
{
   int difference = (int)Math.Ceiling(episodeDuration - remaningTime);
    Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {difference} more minutes.");
}