//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Random rnd = new Random();
int number = rnd.Next(100, 1000);
int firstDigit = (number / 100) * 10;
int lastDigit = number % 10;
int result = firstDigit+lastDigit;
System.Console.WriteLine(number);
System.Console.WriteLine(result);