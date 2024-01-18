/* 
 int[] firstNumbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

int[] secondNumbers = Console.ReadLine().
    Split().
    Select(int.Parse).
    ToArray();

int sum = 0;

for (int i = 0; i < firstNumbers.Length; i++)
{
    if (firstNumbers[i] == secondNumbers[i])
    {
        sum += firstNumbers[i];
    }
    else
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
}

Console.WriteLine($"Arrays are identical. Sum: {sum}");
*/

int[] firstNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] secondNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
bool isEqual = false; 

for (int i = 0; i < firstNumbers.Length; i++)
{
    if (firstNumbers[i] != secondNumbers[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        isEqual = false;
        break;

    }
    else
    {
        sum += firstNumbers[i];
        isEqual = true;
        
    }
}
if (isEqual)
{

  Console.WriteLine($"Arrays are identical. Sum: {sum}");

}