string nameOfActor = Console.ReadLine();
double initialPoints = double.Parse(Console.ReadLine());    
int assesors = int.Parse(Console.ReadLine());



for (int i = 0; i < assesors && initialPoints <= 1250.5; i++)
{
    string nameOfAssesor = Console.ReadLine();
    double pointsFromAssesor = double.Parse(Console.ReadLine());

    initialPoints += (((nameOfAssesor.Length)* pointsFromAssesor) / 2);

}
if(initialPoints <= 1250.5)
{
    Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - initialPoints:F1} more!");
}
else
{
    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {initialPoints:F1}!");
}