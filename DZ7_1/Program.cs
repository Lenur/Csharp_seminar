﻿/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);

// Метод создания массива, размером m x n, случайными вещественными числами.
double[,] GetMatrix(int m, int n)
{
    double[,] matr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().NextDouble()*20-10; //[-10,00 ... 10,00)
        }
    }
    return matr;
}

// Метод вывода массива размером m x n.
void PrintMatrix(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}