int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int totalCakePieces = width * length;
string input = Console.ReadLine();

while(input != "STOP")
{
    int piecesToSubtract = int.Parse(input);
    totalCakePieces -= piecesToSubtract;
    if (totalCakePieces < 0)
    {
        break;
    }
    input = Console.ReadLine();
}
if (totalCakePieces >= 0)
{
    Console.WriteLine($"{totalCakePieces} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(totalCakePieces)} pieces more.");
}