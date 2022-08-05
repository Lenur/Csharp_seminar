/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Введите 3 числа:");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());

if ((a>b) & (a>c))
    Console.WriteLine($"{a} максимальное число!");
else if ((b>a) & (b>c))
    Console.WriteLine($"{b} максимальное число!");
else
    Console.WriteLine($"{c} максимальное число!");