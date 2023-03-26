// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
Console.Clear();
int stroki = ReadInt("Введите количество строк: ");
int stolb = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[stroki, stolb];
void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
}
void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
FillArray2D(numbers);
PrintArray2D(numbers);