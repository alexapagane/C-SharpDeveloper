int letterCount = int.Parse(Console.ReadLine());

string smsText = string.Empty;

for (int i = 0; i < letterCount; i++)
{
    string line = Console.ReadLine();
    int clicksCount = line.Length;
    char digitChar = line[0];



    switch (digitChar)
    {
        case '0':
            smsText += ' ';
            break;
       // case '1':break;
        case '2':
            smsText += (char)(clicksCount + 96); 
            break;
        case '3':
            smsText += (char)(clicksCount + 99);
            break;
        case '4':
            smsText += (char)(clicksCount + 102);
            break;
        case '5':
            smsText += (char)(clicksCount + 105);
            break;
        case '6':
            smsText += (char)(clicksCount + 108);
            break;
        case '7':
            smsText += (char)(clicksCount + 111);
            break;
        case '8':
            smsText += (char)(clicksCount + 115);
            break;
        case '9':
            smsText += (char)(clicksCount + 118);
            break;

    }
   
}
    Console.WriteLine(smsText);