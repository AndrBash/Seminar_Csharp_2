// Программа создает числа Фибоначи
Console.Clear();
// F(1) = 1
// F(2) = 1
// F(n) = F(n-1) +f(n-2)

double Fibo(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibo(n-1) + Fibo(n-2);
}
for(int i = 1; i < 20; i++)
{
    Console.WriteLine($"f({i}) = {Fibo(i)}");
}
// Больше 50 уже начинает тупить комп