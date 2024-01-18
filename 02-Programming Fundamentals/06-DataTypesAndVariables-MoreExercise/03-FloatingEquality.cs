double eps = 0.000001;
double numberOne = 0.0;
double numberTwo= 0.0;


numberOne = double.Parse(Console.ReadLine());
numberTwo = double.Parse(Console.ReadLine());
bool isEqual = Math.Abs(numberOne - numberTwo) < eps;

if (isEqual)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}