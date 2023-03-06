// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B
Console.Clear();
void Sum (int A, int B)
{
    double Stepen = Math.Pow(A, B);
    System.Console.WriteLine(Stepen);
}
int inputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int A = inputNumberWithMessage("Введите число A");
int B = inputNumberWithMessage("Введите число B");
System.Console.WriteLine("Result A^B is:");
Sum(A, B);