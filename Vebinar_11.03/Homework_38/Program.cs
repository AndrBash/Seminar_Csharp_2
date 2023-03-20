// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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
(int minNum, int maxNum) GetMinAndMax(int[] array)
{
    (int minNum, int maxNum) amounts = (array[0], array[0]);

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < amounts.minNum)
        {
            amounts.minNum = array[i];
        }
        else
        {
            i = i++;
        }
        if (array[i] > amounts.maxNum)
        {
            amounts.maxNum = array[i];
        }
        else
        {
            i = i++;
        }
    }
    return amounts;
}
int size = 4;
int[] array = CreateAndFillArray(size, 0, 10);
PrintArrayInConsole(array);
(int minNum, int maxNum) amounts = GetMinAndMax(array);
System.Console.WriteLine($"Минимальное число = {amounts.minNum}, Максимальное число = {amounts.maxNum}, разница данных чисел {amounts.maxNum - amounts.minNum}");

