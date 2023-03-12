// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
System.Console.WriteLine("ВВедите число");
int n = Convert.ToInt32(Console.ReadLine());
float kub = 0;
for (int i = 1; i <= n; i++)
{
    kub = (float)i*(float)i*(float)i;
}
System.Console.WriteLine(kub);