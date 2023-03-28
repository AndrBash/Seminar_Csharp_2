// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
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
void FindMinSumRow(int[,] array)
{
    int MinSum = 0;
    int MinRow = 0;
    int Sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        MinSum += array [0, i];        
    }
    System.Console.WriteLine($"минимальная {MinSum}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum += array [i, j];
            System.Console.WriteLine($"суммы {i} = {Sum}");            
        }    
        if (Sum < MinSum)
        {
            MinSum = Sum;
            System.Console.WriteLine($"проверка суммы {i} = {MinSum}");
            MinRow = i;
            System.Console.WriteLine($"проверка строки {i} = {MinRow}");
        }
        else
        {
            Sum = 0;    
        }
    }    
    System.Console.WriteLine($"минимальная сумма {MinSum} в {MinRow+1} строке");
}
FindMinSumRow(numb);
