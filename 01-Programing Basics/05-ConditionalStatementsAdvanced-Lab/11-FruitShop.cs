string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();  
double quantity = double.Parse(Console.ReadLine());

double price = 0;

if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
{
    switch (fruit)
    {
        case "banana":
            price = 2.50;
            double priceFinal = price * quantity;
            Console.WriteLine($"{priceFinal:F2}");
            break;
        case "apple":
            price = 1.20;
            double priceFinal1 = price * quantity;
            Console.WriteLine($"{priceFinal1:F2}");
            break;
        case "orange":
            price = 0.85;
            double priceFinal2 = price * quantity;
            Console.WriteLine($"{priceFinal2:F2}");
            break;
        case "grapefruit":
            price = 1.45;
            double priceFinal3 = price * quantity;
            Console.WriteLine($"{priceFinal3:F2}");
            break;
        case "kiwi":
            price = 2.70;
            double priceFinal4 = price * quantity;
            Console.WriteLine($"{priceFinal4:F2}");
            break;
        case "pineapple":
            price = 5.50;
            double priceFinal5 = price * quantity;
            Console.WriteLine($"{priceFinal5:F2}");
            break;
        case "grapes":
            price = 3.85;
            double priceFinal6 = price * quantity;
            Console.WriteLine($"{priceFinal6:F2}");
            break;
       default:
            Console.WriteLine("error");
            break;

    }
}
else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
{
    switch (fruit)
    {
        case "banana":
            price = 2.70;
            double priceFinal = price * quantity;
            Console.WriteLine($"{priceFinal:F2}");
            break;
        case "apple":
            price = 1.25;
            double priceFinal1 = price * quantity;
            Console.WriteLine($"{priceFinal1:F2}");
            break;
        case "orange":
            price = 0.90;
            double priceFinal2 = price * quantity;
            Console.WriteLine($"{priceFinal2:F2}");
            break;
        case "grapefruit":
            price = 1.60;
            double priceFinal3 = price * quantity;
            Console.WriteLine($"{priceFinal3:F2}");
            break;
        case "kiwi":
            price = 3.00;
            double priceFinal4 = price * quantity;
            Console.WriteLine($"{priceFinal4:F2}");
            break;
        case "pineapple":
            price = 5.60;
            double priceFinal5 = price * quantity;
            Console.WriteLine($"{priceFinal5:F2}");
            break;
        case "grapes":
            price = 4.20;
            double priceFinal6 = price * quantity;
            Console.WriteLine($"{priceFinal6:F2}");
            break;
        default:
            Console.WriteLine("error");
            break;

    }
}
else
{
    Console.WriteLine("error");
}