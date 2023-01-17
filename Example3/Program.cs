//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 7) Console.WriteLine("Такого дня недели не существует.");
else
{
    if (number == 6 || number == 7) Console.WriteLine($"День {number} - выходной.");
    else
    {
        Console.WriteLine($"День {number} - не выходной.");
    }
}
