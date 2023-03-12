// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
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
(int Chetny, int UnChetny) GetCountChetnyAndUnChetny(int[] array)
{
    (int Chetny, int UnChetny) count = (0, 0);

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count.Chetny = count.Chetny + 1;
        else
        {
            count.UnChetny = count.UnChetny + 1;
        }
    }
    return count;
}
int size = 4;
int[] array = CreateAndFillArray(size, 000, 999);
PrintArrayInConsole(array);
(int Chetny, int UnChetny) count = GetCountChetnyAndUnChetny(array);
System.Console.WriteLine($"Четных = {count.Chetny}, нечетных = {count.UnChetny}");