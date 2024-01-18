int linesOfInput = int.Parse(Console.ReadLine());
string input = string.Empty;

for (int i = 0; i < linesOfInput; i++)
{
    input = Console.ReadLine();
    
    string numberLeft = "";
    string numberRight = "";
    

    int k = 0;

    while (input[k] != ' ')
    {
        numberLeft += input[k];
        k++;
    }
    while ((k + 1) != input.Length)
    {
        numberRight+= input[k + 1];
        k++;
    }
     

    long number1 = long.Parse(numberLeft);
    long number2 = long.Parse(numberRight);
         

    if (number1 >= number2)
    {
       int sum = 0;
        for (int j = numberLeft.Length; j >= 0; j--)
        {
            byte numberToSum = (byte)Math.Abs(number1 % 10);
            sum += (int)numberToSum;
            number1 /= 10;


        }
        Console.WriteLine(sum);
    }
    else
    {
       
        int sum = 0;
        for (int j = numberRight.Length; j >= 0; j--)
        {
          byte numberToSum = (byte)Math.Abs(number2 % 10);
            sum += (int)numberToSum;
            number2 /= 10;

       
        }
        Console.WriteLine(sum);
    }
   
    
    
}