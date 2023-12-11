double depositAmount = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double interest = depositAmount * annualInterestRate/100;
double interestPerMonth = interest / 12;
double totalAmount = depositAmount + depositTerm * interestPerMonth;

Console.WriteLine(totalAmount);