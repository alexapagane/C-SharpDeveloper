int sequenceLength = int.Parse(Console.ReadLine());
int bestIndex = 1;
int bestStartIndex = int.MaxValue;
int bestSum = 0;
int bestCount = 0;
string[] bestSequence = Array.Empty<string>();
int index = 0;
string sequence;

while ((sequence =Console.ReadLine()) != "Clone them!")
{
    index += 1;
    int count = 0;
    int sum = 0;
   
    string[] sequenceArr = sequence.Split("!", StringSplitOptions.RemoveEmptyEntries);

    if(bestSequence.Length == 0)
    {
        bestSequence = sequenceArr;
    }
    for (int i = sequenceLength - 1; i >= 0; i--)
    {
        if (sequenceArr[i] == "1")
        {
            sum++;
            count++;
            if (bestCount < count || bestStartIndex > i || bestSum < sum)
            {
                bestSequence = sequenceArr;
                bestStartIndex = i;
                bestIndex = index;
                bestCount = count;
                bestSum = sum;
            }
        }
        else
        {
            count = 0;
        }
    }
}

Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestSequence));