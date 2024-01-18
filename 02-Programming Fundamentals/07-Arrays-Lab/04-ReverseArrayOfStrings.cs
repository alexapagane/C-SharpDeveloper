string[] elements = Console.ReadLine().Split().ToArray();

for (int i = 0; i < elements.Length / 2; i++)
{
    string firstElement = elements[i];
    string lastElement = elements[elements.Length - 1 -i];

    elements[i] = lastElement;
    elements[elements.Length - 1 -i] = firstElement;

}
Console.WriteLine(string.Join(" ", elements));

/*
 string[] elements = Console.ReadLine().Split();

 for (int i = elements.Length - 1; i >= 0; i--)
 {
     Console.Write($"{elements[i]} ");
 }
*/