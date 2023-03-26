// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
int stroki = ReadInt("Введите инжекс строки: ");
int stolb = ReadInt("Введите индекс столбца: ");
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
if (stroki < numb.GetLength(0) && stolb < numb.GetLength(1)) 
{
    System.Console.WriteLine($"Значение элемента массива на позиции {stroki},{stolb} = {numb[stroki, stolb]}");
}
else
{
    System.Console.WriteLine($"Значение элемента массива на позиции {stroki},{stolb} - не существует");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
