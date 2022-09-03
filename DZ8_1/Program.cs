/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
// Метод сортрировки по убыванию элементов каждой строки двумерного массива
void SortRows(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - 1; k++)  //проверка по количеству итераций
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {
                    int tmp = inArray[i, k];
                    inArray[i, k] = inArray[i, k + 1];
                    inArray[i, k + 1] = tmp;
                }
            }
        }
    }
}

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
SortRows(array);
PrintArray(array);
