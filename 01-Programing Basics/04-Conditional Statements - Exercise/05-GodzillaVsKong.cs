double budgetFilm =double.Parse(Console.ReadLine());
double extraNumber = double.Parse(Console.ReadLine());
double extraPriceGarments = double.Parse(Console.ReadLine());

double decour = budgetFilm * 0.1;
if(extraNumber > 150)
{
 extraPriceGarments = extraPriceGarments * 0.9;
}
double sumFilm = decour + (extraNumber * extraPriceGarments);

if(sumFilm > budgetFilm)
{
sumFilm -= budgetFilm;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {sumFilm:F2} leva more.");
}


else
{
    budgetFilm -= sumFilm;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budgetFilm:F2} leva left.");
    
}