/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
*/

Console.Write("Введите число 1: ");
int sqr = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number = int.Parse(Console.ReadLine());

if (Convert.ToInt32(Math.Pow(number, 2)) == sqr)
{
    Console.WriteLine($"Да, {sqr} это квадрат числа {number}");
}
else
{
    Console.WriteLine($"Нет, {sqr} это не квадрат числа {number}");
}
