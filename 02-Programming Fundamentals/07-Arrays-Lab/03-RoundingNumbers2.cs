double[] doubleNumbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();
int[] roundedNumbers = new int[doubleNumbers.Length];
for (int i = 0; i < roundedNumbers.Length; i++)
{
    roundedNumbers[i]= (int)Math.Round(doubleNumbers[i], MidpointRounding.AwayFromZero);
}

for (int i = 0;i < roundedNumbers.Length;i++)
{
    Console.WriteLine($"{doubleNumbers[i]} => {roundedNumbers[i]}");
}