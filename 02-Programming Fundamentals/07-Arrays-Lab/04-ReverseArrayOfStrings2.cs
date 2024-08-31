 string[] input  = Console.ReadLine().Split();
 List<string> result = new List<string>();

 for (int i = input.Length - 1; i >= 0; i--)
 {
    result.Add(input[i]);
 }

Console.WriteLine(string.Join(" ",result));