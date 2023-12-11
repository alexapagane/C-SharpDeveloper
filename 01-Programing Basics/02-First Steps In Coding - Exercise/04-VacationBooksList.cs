int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToRead = int.Parse(Console.ReadLine());

int totalHours = pages / pagesPerHour;
int nesessaryHoursPerDay = totalHours / daysToRead;

Console.WriteLine(nesessaryHoursPerDay);