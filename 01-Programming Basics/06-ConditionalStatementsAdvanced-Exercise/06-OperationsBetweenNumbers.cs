int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

double result = 0;
string resultType = "";

switch (operation)
{
    case '+':
        result = num1 + num2;
        if(result % 2 == 0)
        {
            resultType = "even";
        }
        else
        {
            resultType = "odd";
        }
        Console.WriteLine($"{num1} + {num2} = {result} - {resultType}");
        break;
    case '-':
        result = num1 - num2;
        if (result % 2 == 0)
        {
            resultType = "even";
        }
        else
        {
            resultType = "odd";
        }
        Console.WriteLine($"{num1} - {num2} = {result} - {resultType}");
        break;
    case '*':
        result = num1 * num2;
        if (result % 2 == 0)
        {
            resultType = "even";
        }
        else
        {
            resultType = "odd";
        }
        Console.WriteLine($"{num1} * {num2} = {result} - {resultType}");
        break;
    case '/':
       
        if(num2 == 0)
        {
            Console.WriteLine($"Cannot divide {num1} by zero");
        }
        else
        {
            result = (double) num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result:F2}");
        }
        break;
    case '%':
        if (num2 == 0)
        {
            Console.WriteLine($"Cannot divide {num1} by zero");
        }
        else
        {
            result = num1 % num2;
            Console.WriteLine($"{num1} % {num2} = {result}");
        }
        break;
    default:
        break;
}