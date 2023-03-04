// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();
System.Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 7 == 0 && Number % 23 == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Не кратно");
}