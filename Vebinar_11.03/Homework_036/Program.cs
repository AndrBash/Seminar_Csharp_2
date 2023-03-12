// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(leftRangeValue, rightRangeValue);
    }
    return array;
}
void PrintArrayInConsole(int[] array)
{
    System.Console.WriteLine(string.Join(",", array));
}
int size = 4;
int[] array = CreateAndFillArray(size, 0, 10);
PrintArrayInConsole(array);
int summ = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        summ = summ + array[i];
    }
System.Console.WriteLine($"Сумма чисел на нечетных позициях = {summ}");