string town = Console.ReadLine();
double volumeOfSales = double.Parse(Console.ReadLine());
double comission = 0;

switch (town)
{
    case "Sofia":
        if (volumeOfSales >= 0 && volumeOfSales <= 500)
        {
            comission = volumeOfSales * 0.05;
            Console.WriteLine($"{comission:F2}");
        }
        else if (volumeOfSales > 500 && volumeOfSales <= 1000)
        {
            comission = volumeOfSales * 0.07;
            Console.WriteLine($"{comission:F2}");
        }

        else if (volumeOfSales> 1000 && volumeOfSales <= 10000)
        {
            comission = volumeOfSales * 0.08;
            Console.WriteLine($"{comission:F2}");

        }
        else if (volumeOfSales > 10000)
        {
            comission = volumeOfSales * 0.12;
            Console.WriteLine($"{comission:F2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "Varna":
        if (volumeOfSales >= 0 && volumeOfSales <= 500)
        {
            comission = volumeOfSales * 0.045;
            Console.WriteLine($"{comission:F2}");
        }
        else if (volumeOfSales > 500 && volumeOfSales <= 1000)
        {
            comission = volumeOfSales * 0.075;
            Console.WriteLine($"{comission:F2}");
        }
        else if (volumeOfSales > 1000 && volumeOfSales <= 10000)
        {
            comission = volumeOfSales * 0.10;
            Console.WriteLine($"{comission:F2}");
        }
        else if (volumeOfSales > 10000)
        {
            comission = volumeOfSales * 0.13;
            Console.WriteLine($"{comission:F2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "Plovdiv":
        if (volumeOfSales >= 0 && volumeOfSales <= 500)
        {
            comission = volumeOfSales * 0.055;
            Console.WriteLine($"{comission:F2}");
        }
        else if (volumeOfSales >500 && volumeOfSales <= 1000)
        {
            comission = volumeOfSales * 0.08;
            Console.WriteLine($"{comission:F2}");
        }
        else if (volumeOfSales >1000 && volumeOfSales <= 10000)
        {
            comission = volumeOfSales * 0.12;
            Console.WriteLine($"{comission:F2}");
        }
        else if (volumeOfSales > 10000)
        {
            comission = volumeOfSales * 0.145;
            Console.WriteLine($"{comission:F2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    default: Console.WriteLine("error"); 
        break;
}