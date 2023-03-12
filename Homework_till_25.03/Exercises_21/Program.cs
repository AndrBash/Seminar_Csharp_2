// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.Clear();
System.Console.WriteLine("Введите координыту Х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координыту Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координыту Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координыту Х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координыту Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координыту Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double x0 = Math.Pow(x2 - x1, 2);
double y0 = Math.Pow(y2 - y1, 2);
double z0 = Math.Pow(z2 - z1, 2);
double length = Math.Sqrt(x0 + y0 + z0);
System.Console.WriteLine($"Длина отрезка = {length}");