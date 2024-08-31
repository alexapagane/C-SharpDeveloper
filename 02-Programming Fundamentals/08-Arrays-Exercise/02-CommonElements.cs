string firstArray = Console.ReadLine();
string[] firstCompare = firstArray.Split();
string secondArray = Console.ReadLine();
string[] secondCompare = secondArray.Split();

for (int i = 0; i < firstCompare.Length; i++)
{
    for (int j = 0; j < secondCompare.Length; j++)
    {
        if (firstCompare[i] == secondCompare[j])
        {
            Console.Write($"{firstCompare[i]} ");
            break;
        }
    }
}