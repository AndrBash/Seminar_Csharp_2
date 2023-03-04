//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
Console.Clear();
Random rnd = new Random();
int number = rnd.Next(1,100);
//System.Console.WriteLine(number);
//int number = new Random().Next(10,100); - можно использовать если нет множества рандомов
int firstDigit = number / 10;
int lastDigit = number % 10;
int maxDigit = Math.Max(firstDigit, lastDigit);
System.Console.WriteLine(number);
System.Console.WriteLine(maxDigit);
//System.Console.WriteLine(Math.Max(firstDigit, lastDigit)); - вариант сокращения записи