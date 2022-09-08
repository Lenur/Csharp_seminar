/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. (Решать методом рекурсии, на семинаре третья задача похожа)
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(SumNumbers(m, n));

int SumNumbers(int start, int end)
{
    int sum = start;
    if (start == end) return start;
    return sum += SumNumbers(start+1, end);
}
