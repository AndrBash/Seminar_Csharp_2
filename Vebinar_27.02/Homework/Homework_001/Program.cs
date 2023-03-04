// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа
Random rnd = new Random();
int number = rnd.Next(100, 1000);
int firstTwoDigits = number / 10;
int midleDigit = firstTwoDigits % 10;
System.Console.WriteLine(number);
System.Console.WriteLine(firstTwoDigits);
System.Console.WriteLine(midleDigit);