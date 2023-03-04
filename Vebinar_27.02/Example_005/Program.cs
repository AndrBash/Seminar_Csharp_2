// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого
Console.Clear();
System.Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
bool isSquare = Math.Pow(firstNumber, 2) == secondNumber || Math.Pow(secondNumber, 2) == firstNumber;
if (isSquare)
    System.Console.WriteLine("Yes");
else
    System.Console.WriteLine("No");