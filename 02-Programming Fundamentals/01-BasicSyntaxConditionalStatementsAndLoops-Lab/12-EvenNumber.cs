double number = double.Parse(Console.ReadLine());

while (number % 2 != 0)
{ 
        Console.WriteLine("Please write an even number.");
        number = double.Parse(Console.ReadLine()); 
   
}

Console.WriteLine($"The number is: {Math.Abs(number)}");
