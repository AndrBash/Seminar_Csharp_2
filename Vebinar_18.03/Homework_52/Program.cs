// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
int[,] numb = new int[3, 4];
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintArray2D(int[,] array)
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
FillArray2D(numb);
PrintArray2D(numb);
for (int i = 0; i < numb.GetLength(1); i++)
{    
    double result = 0.0;
    for (int j = 0; j < numb.GetLength(0); j++)
    {
        result = result + numb[j, i];
        //для проверки алгоритма:
        //System.Console.WriteLine($"{numb[j, i]}");
        //System.Console.WriteLine($"{result}");
        //System.Console.WriteLine($"{numb.GetLength(0)}");
    }
    System.Console.WriteLine($"среднее арифметическое по столбцу {i+1} = {result/numb.GetLength(0)}");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}