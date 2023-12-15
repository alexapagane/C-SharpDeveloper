int failedTimes = int.Parse(Console.ReadLine());
string input = Console.ReadLine();

string lastExcersise = string.Empty;
int evaluation;

int evaluationCount = 0;
int evaluationSum = 0;
int failedCount = 0;

while(input != "Enough")
{
    lastExcersise = input;
    evaluation = int.Parse(Console.ReadLine());
    evaluationCount++;
    evaluationSum += evaluation;

    if(evaluation <= 4)
    {
        failedCount++;
        if(failedCount  == failedTimes)
        {
            Console.WriteLine($"You need a break, {failedTimes} poor grades.");
            break;
        }
    }
    input = Console.ReadLine();
}
if (input == "Enough")
{
    Console.WriteLine($"Average score: {(double)evaluationSum / evaluationCount:F2}");
    Console.WriteLine($"Number of problems: {evaluationCount}");
    Console.WriteLine($"Last problem: {lastExcersise}");
}