int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());    

int minutesTotal = (hours * 60) + minutes + 15;

int newHours = minutesTotal  / 60;
int newMinutes = minutesTotal % 60;

if (newHours == 24)
{
    newHours = 0;
}

if (newMinutes < 10) 
{
    
     
    Console.WriteLine($"{newHours}:0{newMinutes}");
}
else
{
    
    Console.WriteLine($"{newHours}:{newMinutes}");
}

/*
int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());
minute +=15;
hour += minute /60;
minute %= 60;
hour %=24;

string formattedMinute = minute.ToString("D2");
Console.WriteLine($"{hour}:{formattedMinute}");
*/