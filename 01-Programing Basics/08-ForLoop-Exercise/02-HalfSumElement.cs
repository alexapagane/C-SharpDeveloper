int n = int.Parse(Console.ReadLine());

int sum = 0;    
int max = int.MinValue;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    sum += currentNumber;
    if (currentNumber > max)
    {
        max = currentNumber;
    }

}
int sumWithioutMax = sum - max;
if (sumWithioutMax == max)
{
     Console.WriteLine("Yes");
     Console.WriteLine($"Sum = {max}");
}
else
{
    int diff = Math.Abs(max - sumWithioutMax);

    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}