int number = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number; i++)
{
      int currentNumber = i * 2 - 1;
      Console.WriteLine(currentNumber);
      sum += currentNumber;
    
   
    
}
Console.WriteLine($"Sum: {sum}");
