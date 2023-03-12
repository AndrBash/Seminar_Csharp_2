// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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
(int moreThenZero, int lessThenZero) GetSummsNumbersLessAndMoreThenZero(int[] array)
{
    (int moreThenZero, int lessThenZero) amounts = (0, 0);

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            amounts.moreThenZero += array[i];
        else
        {
            amounts.lessThenZero += array[i];
        }
    }
    return amounts;
}
int size = 12;
int[] array = CreateAndFillArray(size, -9, 10);
PrintArrayInConsole(array);
(int moreThenZero, int lessThenZero) amounts = GetSummsNumbersLessAndMoreThenZero(array);
System.Console.WriteLine($"Больше 0 = {amounts.moreThenZero}, меньше 0 = {amounts.lessThenZero}");