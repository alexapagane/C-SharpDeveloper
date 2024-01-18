string[] daysOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Invalid day!");
    return;
}

Console.WriteLine(daysOfWeek[number - 1]);