string input = Console.ReadLine();

while (input != "END")
{

    
    if (int.TryParse(input, out int integer))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if(float.TryParse(input, out float floatingNumber))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if(bool.TryParse(input, out bool boolean))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else if(char.TryParse(input, out char character))
    {
        Console.WriteLine($"{input} is character type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }

    input = Console.ReadLine();

}