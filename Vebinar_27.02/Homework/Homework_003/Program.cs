// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 7)
{
    if (num == 6 || num == 7)
    {
        System.Console.WriteLine("Этот день выходной");
    }
    else
    {
        System.Console.WriteLine("День рабочий");
    }
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}
