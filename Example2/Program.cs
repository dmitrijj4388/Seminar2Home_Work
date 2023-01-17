//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int a = number / 100;
int b = a % 10;
if (number / 100 == 0) Console.WriteLine("Третьей цифры нет.");
else
    if (a < 10) Console.WriteLine($"Третья цифра справа на лево - {a}");
    else
    {
        Console.WriteLine($"Третья цифра справа на лево - {b}");
    }
    

