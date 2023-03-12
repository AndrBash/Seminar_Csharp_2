// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом
Console.Clear();
System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;
if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write("Палиндром");
    }
    else
    {
        Console.Write("Нe палиндром");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}