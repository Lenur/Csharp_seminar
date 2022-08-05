/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
Console.Write("Введите 1 число: ");
int a=int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b=int.Parse(Console.ReadLine());
if (a>b)
    Console.WriteLine($"{a}-max, {b}-min");
else
    Console.WriteLine($"{b}-max, {a}-min");