//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если второе число не кратно числу первому, 
//то программа выводит остаток от деления
Console.Clear();
System.Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % secondNumber == 0)
{
    System.Console.WriteLine("Второе число кратное первому");
}
else
{
    System.Console.WriteLine($"Не кратно= {firstNumber % secondNumber}");
}