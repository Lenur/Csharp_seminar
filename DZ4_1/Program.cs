/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите число х: ");
int x=int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n=int.Parse(Console.ReadLine());

// математический метод с помощью цикла
//int result=1;
// for (int i=1; i<=n; i++)
// {
//     result *= x;
// }
//Console.WriteLine(result);

double result2 = Math.Pow(x, n);
Console.WriteLine(result2);