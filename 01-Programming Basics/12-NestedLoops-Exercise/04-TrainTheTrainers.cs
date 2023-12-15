int juryPeople = int.Parse(Console.ReadLine());
string presentation = Console.ReadLine();

double averageTotalMark = 0;
double counterTotal = 0;

while(presentation != "Finish")
{ 
      int counter = 0;
      double sum = 0;
    for(int i = 0; i < juryPeople; i++)
    { 
        double mark = double.Parse(Console.ReadLine());
        sum += mark;
        averageTotalMark += mark;
        counter++;
        counterTotal++;
        if (counter == juryPeople)
        {
            double averageMark = (double) sum / juryPeople;
            Console.WriteLine($"{presentation} - {averageMark:F2}.");
            break;
        }
        
   

    }
    presentation = Console.ReadLine();  

}
Console.WriteLine($"Student's final assessment is {(averageTotalMark / counterTotal):F2}.");