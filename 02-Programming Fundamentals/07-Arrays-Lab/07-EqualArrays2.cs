int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0;i < firstArray.Length; i++)
{
    if (firstArray[i] != secondArray[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
}
int sum  = 0;
foreach (var currentNumber in secondArray)
{
    sum += currentNumber;
}
Console.WriteLine($"Arrays are identical. Sum: {sum}");