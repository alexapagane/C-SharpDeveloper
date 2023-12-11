int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fisherman  = int.Parse(Console.ReadLine());

double price = 0;

switch (season)
{
    case "Spring":
        price = 3000;
        if (fisherman <= 6)
        {
            price -= price * 0.1;
        }
        else if(fisherman >= 7 &&  fisherman <= 11)
        {
            price -= price * 0.15;
        }
        else if (fisherman >= 12)
        {
            price -= price * 0.25;
        }

        if(fisherman % 2 == 0)
        {
            price -= price * 0.05;
        }
        break;
    case "Summer":
        price = 4200;
        if (fisherman <= 6)
        {
            price -= price * 0.1;
        }
        else if (fisherman >= 7 && fisherman <= 11)
        {
            price -= price * 0.15;
        }
        else if (fisherman >= 12)
        {
            price -= price * 0.25;
        }

        if (fisherman % 2 == 0)
        {
            price -= price * 0.05;
        }
        break;
        
    case "Autumn":
        price = 4200;
        if (fisherman <= 6)
        {
            price -= price * 0.1;
        }
        else if (fisherman >= 7 && fisherman <= 11)
        {
            price -= price * 0.15;
        }
        else if (fisherman >= 12)
        {
            price -= price * 0.25;
        }    
        break;
       
    case "Winter":
        price = 2600;
        if (fisherman <= 6)
        {
            price -= price * 0.1;
        }
        else if (fisherman >= 7 && fisherman <= 11)
        {
            price -= price * 0.15;
        }
        else if (fisherman >= 12)
        {
            price -= price * 0.25;
        }

        if (fisherman % 2 == 0)
        {
            price -= price * 0.05;
        }
        break;
       
}

double differnce = Math.Abs(price - budget);

if (budget >= price)
{
    Console.WriteLine($"Yes! You have {differnce:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {differnce:F2} leva.");
}