// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int ResultCode(string message)
{
    System.Console.Write(message);
    string valueIn = System.Console.ReadLine();
    int result = int.Parse(valueIn);
    return result;
}
int[] NewArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random values = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = values.Next(minValue, maxValue +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
}
int Length = ResultCode("Введите длину массива: ");
int min = ResultCode("Начальное занчение: ");
int max = ResultCode("Конечнре значение: ");
int[] array = NewArray(Length, min, max);
PrintArray(array);
