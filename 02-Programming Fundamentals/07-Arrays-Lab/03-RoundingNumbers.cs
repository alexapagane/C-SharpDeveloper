double[] numbers = Console.ReadLine().
               Split().
               Select(double.Parse).
               ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    double currentNumber = numbers[i];
    numbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
    Console.WriteLine($"{currentNumber} => {numbers[i]}");
}