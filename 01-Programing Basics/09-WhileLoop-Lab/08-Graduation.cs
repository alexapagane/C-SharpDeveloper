double sumGrades = 0;
int grade = 1;
int badGrades = 0;
string name = Console.ReadLine();

while (grade <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if(currentGrade < 4.00)
    {
        badGrades++;
        if(badGrades > 1)
        {
            break;
        }

        continue;
    }


    grade++;
    sumGrades += currentGrade;
}
if(badGrades > 1)
{
    Console.WriteLine($"{name} has been excluded at {grade} grade");
}
else
{
    double averageGrade = sumGrades / 12;
    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
}