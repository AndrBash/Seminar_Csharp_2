// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int ResultCode(string message)
{
    System.Console.Write(message);
    string valueIn = System.Console.ReadLine();
    int result = int.Parse(valueIn);
    return result;
}
int SummaDigits(int index)
{
    int result = 0;
    while(index > 0)
    {
        result = result + index % 10;
        index = index / 10;
    }
    return result;
}
int index = ResultCode("Введите число: ");
System.Console.WriteLine($"Сумма чисел в числе {index} = {SummaDigits(index)}");