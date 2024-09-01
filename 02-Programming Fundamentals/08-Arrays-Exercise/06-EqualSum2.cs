string[] arr = Console.ReadLine().Split();
int[] numbers = arr.Select(int.Parse).ToArray();
bool flag = false;
for (int i = 0; i < numbers.Length; i++)
{
    flag = false;
    if (numbers.Length == 1)
    {
        Console.WriteLine(0);
        break;
    }

    int sumLeft = 0;
    int sumRight = 0;
    for (int j = 0; j < i; j++)
    {
        sumLeft += numbers[j];
    }
    for (int j = 1 + i; j < numbers.Length; j++)
    {
        sumRight += numbers[j];
    }
    if (sumLeft != sumRight)
    {
        flag = true;
    }
    else if (sumLeft == sumRight)
    {
        Console.WriteLine(i);
        break;
    }
}
if (flag)
{
    Console.WriteLine("no");
}