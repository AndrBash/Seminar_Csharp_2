// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Введите элементы через запятую):");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(new char[] { ',' }), int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
    else
    {
        count = count;
    }
}
Console.WriteLine($"Количествово элементов больше 0 = {count}");