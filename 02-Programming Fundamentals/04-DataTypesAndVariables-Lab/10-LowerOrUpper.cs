char character = char.Parse(Console.ReadLine());

bool isUpper = char.IsUpper(character);

if (isUpper == true)
{
    Console.WriteLine("upper-case");
}
else
{
    Console.WriteLine("lower-case");
}