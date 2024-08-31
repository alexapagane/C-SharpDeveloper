int n = int.Parse(Console.ReadLine());
List<int> firstList = new List<int>();
List<int> secondList = new List<int>();
for (int i = 1; i <= n; i++)
{
    string line = Console.ReadLine();
    int[] input = line.Split().Select(int.Parse).ToArray();
    for (int j = 0; j < input.Length; j++)
    {
        if ((i % 2 == 0) == false)
        {
            if (j % 2 == 0)
            {
                firstList.Add(input[j]);
            }
            else
            {
                secondList.Add(input[j]);
            }
        }
        else

        {
            if (j % 2 == 0)
            {
                secondList.Add(input[j]);
            }
            else
            {
                firstList.Add(input[j]);
            }
        }
    }
}
Console.WriteLine(string.Join(" ", firstList));
Console.WriteLine(string.Join(" ", secondList));
     