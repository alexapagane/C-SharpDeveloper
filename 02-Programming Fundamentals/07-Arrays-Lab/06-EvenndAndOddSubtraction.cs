int[] numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

int sumOfEvenNumbers = 0;
int sumOfOddNumbers = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sumOfEvenNumbers +=  numbers[i];
    }
    else
    {
        sumOfOddNumbers += numbers[i];
    }
}
Console.WriteLine(sumOfEvenNumbers - sumOfOddNumbers);
