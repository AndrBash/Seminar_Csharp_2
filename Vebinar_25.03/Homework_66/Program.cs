// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumBetweenMN(m, n);
void SumBetweenMN(int m, int n)
{
    Console.Write(Summ(m - 1, n));
}
int Summ(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + Summ(m, n);
        return result;
    }
}