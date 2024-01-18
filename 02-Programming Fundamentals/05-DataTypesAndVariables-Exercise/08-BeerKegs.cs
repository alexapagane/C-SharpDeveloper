int kegsCount = int.Parse(Console.ReadLine());

decimal biggestVolume = decimal.MinValue;
string biggestKegModel = string.Empty;

for (int i = 0; i < kegsCount; i++)
{
    string kegModel = Console.ReadLine();
    decimal radius = decimal.Parse(Console.ReadLine());
    decimal height = decimal.Parse(Console.ReadLine());

    decimal volume = (decimal)Math.PI * (decimal)Math.Pow((double)radius, 2) * height;
    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        biggestKegModel = kegModel;
    }
}
Console.WriteLine(biggestKegModel);