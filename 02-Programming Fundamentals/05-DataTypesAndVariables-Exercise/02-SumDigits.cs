int number = int.Parse(Console.ReadLine());

int sumOfDigits = 0;

while (number != 0)
{
    sumOfDigits = sumOfDigits + number % 10;
    number = number / 10;
}
Console.WriteLine(sumOfDigits);
