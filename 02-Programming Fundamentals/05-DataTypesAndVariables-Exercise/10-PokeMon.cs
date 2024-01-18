int pokePower = int.Parse(Console.ReadLine());
int distanceBetweenTargets = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());

int originalValue = pokePower;
int targetCounter = 0;

while (pokePower >= distanceBetweenTargets)
{
    pokePower = pokePower - distanceBetweenTargets;
    targetCounter++;

    if (pokePower == originalValue * 0.50 && exhaustionFactor != 0)
    {
        pokePower = pokePower / exhaustionFactor;
    }
}
Console.WriteLine(pokePower);
Console.WriteLine(targetCounter);