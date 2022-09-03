/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */
// Метод создания двумерного массива, рандомными числами
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
// Метод вывода двумерного массива
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Метод произведение двух матриц
void MultMatrix(int[,] matr1, int[,] matr2)
{
    int m1 = matr1.GetLength(0);
    int n1 = matr1.GetLength(1);
    int m2 = matr2.GetLength(0);
    int n2 = matr2.GetLength(1);
    int[,] multMatrix = new int[m1, n2];
    if (n1 != m2)
        Console.WriteLine($"Прозведение матриц не существует, т. к., число столбцов 1-й матрицы ({n1})"
                            + $"не равно числу строк 2-й матрицы ({m2})!");
    else
    {
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                for (int k = 0; k < m2; k++) // цикл количество итераций умножений элементов столбца на строку.
                {
                    multMatrix[i, j] += matr1[i, k] * matr2[k, j];
                }
                Console.Write(multMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

int[,] arr1 = { { 2, 4 }, { 3, 2 } }; //GetArray(2, 2, 0, 10);
PrintArray(arr1);
Console.WriteLine();
int[,] arr2 = { { 3, 4 }, { 3, 3 } }; //GetArray(2, 2, 0, 10);
PrintArray(arr2);
Console.WriteLine();
MultMatrix(arr1, arr2);
