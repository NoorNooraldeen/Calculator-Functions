// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Calculator_Functions.Class1;

Class1 classInstance = new Class1();

Console.Write("Enter the first number : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number : ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" the first SUM  is: {classInstance.Add(number1, number2)}");

Console.Write("Enter the third number : ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The second SUM  is: {classInstance.Add(number1, number2, number3)}");


Console.Write("Enter the third number as a DOUBLE: ");
double number4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The third Sum  is: {classInstance.Add(number1, number2, number4)}");
//calc the salary 
Console.Write("Enter the salary: ");
double Salary = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the working hours: ");
int Hours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(classInstance.Salary(Salary, Hours));
    