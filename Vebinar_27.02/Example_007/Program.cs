// Вычислить : 1+2+4+8+...+ 2 в 10 степени.
int n = 2;
int sum = 0;
for (int i = 0; i <= 10; i++)
{
    sum += (int)Math.Pow(n, i);
    System.Console.WriteLine(Math.Pow(n, i));
}
System.Console.WriteLine(sum);
