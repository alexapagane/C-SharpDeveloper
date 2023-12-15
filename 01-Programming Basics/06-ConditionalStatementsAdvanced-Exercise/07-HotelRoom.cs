string month = Console.ReadLine();
int stayOver = int.Parse(Console.ReadLine());

double priceOfStayStudio = 0;
double priceOfStayApartment = 0;
double studioPrice = 0;
double apartmentPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50;
    apartmentPrice = 65;
    priceOfStayStudio = (double)studioPrice * stayOver;
    priceOfStayApartment = (double)apartmentPrice * stayOver;

    if (stayOver > 14)
    {

        priceOfStayStudio -= priceOfStayStudio * 0.3;
        priceOfStayApartment -= priceOfStayApartment * 0.1;
    }
    else if (stayOver > 7 && stayOver <= 14)
    {
        priceOfStayStudio -= priceOfStayStudio * 0.05;
    }
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartmentPrice = 68.70;
    priceOfStayStudio = (double)studioPrice * stayOver;
    priceOfStayApartment = (double)apartmentPrice * stayOver;
    if (stayOver > 14)
    {
        priceOfStayStudio -= priceOfStayStudio * 0.2;
        priceOfStayApartment -= priceOfStayApartment * 0.1;
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = 76;
    apartmentPrice = 77;
    priceOfStayStudio = (double)studioPrice * stayOver;
    priceOfStayApartment = (double)apartmentPrice * stayOver;

    if (stayOver > 14)
    {
        priceOfStayApartment -= priceOfStayApartment * 0.1;
    }
}
Console.WriteLine($"Apartment: {priceOfStayApartment:F2} lv.");
Console.WriteLine($"Studio: {priceOfStayStudio:F2} lv.");
