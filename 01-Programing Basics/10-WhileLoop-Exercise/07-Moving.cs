int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine()); 
int hight = int.Parse(Console.ReadLine());

int totalSpace = width * length * hight;
string input = Console.ReadLine();

while (input != "Done")
{
    int subtractSpace = int.Parse(input);
    totalSpace -= subtractSpace;
    if (totalSpace < 0)
    {
        break;
    }
    input = Console.ReadLine();
}
if(totalSpace >= 0)
{
    Console.WriteLine($"{totalSpace} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(totalSpace)} Cubic meters more.");
}