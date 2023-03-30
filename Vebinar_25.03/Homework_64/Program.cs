// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Natural(number, count);
void Natural(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Natural(n, count + 1);
        System.Console.Write(count + " ");
    }
}