int daysStay = int.Parse(Console.ReadLine());
string abode = Console.ReadLine();
string evaluation = Console.ReadLine();

double roomForOnePerson = 18.00;
double apartment = 25.00;
double presidentsApartment = 35.00;

double nightStay = daysStay - 1.00;
double totalAmount = 0;

if (abode == "room for one person")
{
    totalAmount = nightStay * roomForOnePerson;
    if(evaluation== "positive")
    {
        totalAmount += totalAmount * 0.25;
        
    }
    else
    {
        totalAmount -= totalAmount * 0.1;
    }
}
else if(abode == "apartment")
{

    totalAmount = nightStay * apartment;

     if (nightStay < 10 )
    {
        totalAmount -= totalAmount * 0.3;
        if(evaluation == "positive")
        {
            totalAmount += totalAmount * 0.25;
        }
        else
        {
            totalAmount -= totalAmount * 0.1;
        }
    }
     else if(nightStay >=10 && nightStay <= 15)
    {
        totalAmount -= totalAmount * 0.35;
        if (evaluation == "positive")
        {
            totalAmount += totalAmount * 0.25;
        }
        else
        {
            totalAmount -= totalAmount * 0.1;
        }

    }
     else if(nightStay > 15)
    {
        totalAmount -= totalAmount * 0.50;
        if (evaluation == "positive")
        {
            totalAmount += totalAmount * 0.25;
        }
        else
        {
            totalAmount -= totalAmount * 0.1;
        }
    }
}
else if(abode == "president apartment")
{
    totalAmount = nightStay * presidentsApartment;
    if (nightStay < 10)
    {
        totalAmount -= totalAmount * 0.1;
        if (evaluation == "positive")
        {
            totalAmount += totalAmount * 0.25;
        }
        else
        {
            totalAmount -= totalAmount * 0.1;
        }
    }
    else if (nightStay >= 10 && nightStay <= 15)
    {
        totalAmount -= totalAmount * 0.15;
        if (evaluation == "positive")
        {
            totalAmount += totalAmount * 0.25;
        }
        else
        {
            totalAmount -= totalAmount * 0.1;
        }

    }
    else if (nightStay > 15)
    {
        totalAmount -= totalAmount * 0.20;
        if (evaluation == "positive")
        {
            totalAmount += totalAmount * 0.25;
        }
        else
        {
            totalAmount -= totalAmount * 0.1;
        }
    }

}
Console.WriteLine($"{totalAmount:F2}");