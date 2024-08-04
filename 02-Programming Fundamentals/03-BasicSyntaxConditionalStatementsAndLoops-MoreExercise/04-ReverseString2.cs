string input = Console.ReadLine();
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
string newText = new string(charArray);
Console.WriteLine(newText);