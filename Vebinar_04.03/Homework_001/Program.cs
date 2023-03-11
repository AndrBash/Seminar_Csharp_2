// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B
Console.Clear();
int ResultCode(string message)
{
    System.Console.Write(message);
    string valueIn = System.Console.ReadLine();
    int result = int.Parse(valueIn);
    return result;
}
int Power(int valueBase, int valueStepen)
{
    int power = 1;
    for (int i = 0; i < valueStepen; i++)
    {
        power = power * valueBase;
    }
    return power;
}
bool ValidateExponent(int stepen)
{
    if (stepen < 0)
    {
        System.Console.WriteLine("Показатель меньше нуля");
        return false;
    }
    return true;
}

int valueBase = ResultCode("Введите число 1: ");
int valueStepen = ResultCode("Введите число 2: ");
if (ValidateExponent(valueStepen))
{
    System.Console.WriteLine($"{valueBase} ^ {valueStepen} = {Power(valueBase, valueStepen)}");
}