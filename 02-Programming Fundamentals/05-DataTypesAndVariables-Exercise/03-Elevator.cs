int persons = int.Parse(Console.ReadLine());
int capacityOfPersons = int.Parse(Console.ReadLine());

double fullCourses = (double)persons / capacityOfPersons;
Console.WriteLine(Math.Ceiling(fullCourses));