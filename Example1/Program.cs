//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int a = number % 100;
int b = a / 10;
if (number / 100 < 10 & number / 100 > 0) Console.WriteLine($"Вторая цифра числа - {b}.");
else
Console.WriteLine("Вы ввели не трёхзначное число");

