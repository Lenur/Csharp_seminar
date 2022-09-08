/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
 */
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0) Console.WriteLine("Функцию Аккермана для неотрицательных чисел НЕ ВОЗМОЖНА!");
else Console.WriteLine($"Функция Аккермана чисел А({m},{n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}
