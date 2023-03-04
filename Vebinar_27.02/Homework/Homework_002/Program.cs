// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numstr = Convert.ToString(num);
int Digit = numstr.Length;
if (Digit > 2)
{
    System.Console.WriteLine($"Третья цифра {numstr[2]}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}