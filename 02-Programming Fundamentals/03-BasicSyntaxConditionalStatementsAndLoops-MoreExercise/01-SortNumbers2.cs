int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int[] result = { firstNumber, secondNumber, thirdNumber };
Array.Sort(result);
Array.Reverse(result);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}