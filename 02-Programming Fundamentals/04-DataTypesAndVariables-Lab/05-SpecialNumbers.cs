int n = int.Parse(Console.ReadLine());
for (int num = 1; num <= n; num++)
{
    int sumOfDigits = 0;
    int digits = num;

    while (digits > 0)
    {
        int lastDigit = digits % 10;
        sumOfDigits += lastDigit;
        digits /= 10;
    }
    bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
    if (isSpecial)
    {
        Console.WriteLine($"{num} -> {isSpecial}");
    }
    else
    {
        Console.WriteLine($"{num} -> {isSpecial}");
    }
    
    
}