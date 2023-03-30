// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.Clear();
System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int Function (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (m != 0 && n == 0) 
    {
        return Function(m - 1, 1);
    }
    if (m > 0 && n > 0) 
    {
        return Function(m - 1, Function(m, n - 1));
    }
    else
    {
        return Function(m, n);
    }
}
System.Console.WriteLine($"Функция Аккермана для ({m},{n}) = {Function(m, n)}");