int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

string result = "";

for (int i = numbers.Length - 1; i >= 0; i--)
{
    result += $"{numbers[i]} ";
}

Console.WriteLine(result);