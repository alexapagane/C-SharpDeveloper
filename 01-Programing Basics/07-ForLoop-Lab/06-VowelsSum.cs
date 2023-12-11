string text = Console.ReadLine();

int sum = 0;
for(int i= 0; i < text.Length; i++)
{
    char curentLetter = text[i];
    if (curentLetter == 'a')
    {
        sum += 1;
    }
    else if(curentLetter == 'e')
    {
        sum += 2;
    }
    else if (curentLetter == 'i')
    {
        sum += 3;
    }
    else if (curentLetter == 'o')
    {
        sum += 4;
    }
    else if (curentLetter == 'u')
    {
        sum += 5;
    }

}
Console.WriteLine(sum);