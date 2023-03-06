//Сложение 2-х чисел через функцию
Console.Clear();
void Sum (int num1, int num2)
{
    System.Console.WriteLine(num1 + num2);
}
int inputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
//System.Console.WriteLine("Введите число 1: ");
int num1 = inputNumberWithMessage("Введите число 1");
//System.Console.WriteLine("Введите число 2: ");
int num2 = inputNumberWithMessage("Введите число 2");
Sum(num1, num2);