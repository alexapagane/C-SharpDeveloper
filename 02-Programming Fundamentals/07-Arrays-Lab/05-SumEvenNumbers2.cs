int[] values = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sum = 0;
for (int i = 0; i < values.Length; i++)
{
    int currentValue = values[i];   
    if (currentValue % 2 == 0)
    {
        sum += currentValue;
    }
}
Console.WriteLine(sum);