/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
// Метод нахождения строки с минимальной суммой элементов в строке.
int FindMinRow(int[,] inArray)
{
    int[] res = new int[inArray.GetLength(0)]; //массив для сохранения сумм элементов каждой строки.
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
            res[i] = sum;
        }
        sum = 0;
    }
    int minSum = res[0];
    int minRow = 1;
    for (int k = 1; k < res.Length; k++)
    {
        if (minSum > res[k])
        {
            minSum = res[k];
            minRow = k + 1;
        }
    }
    return minRow;
}

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов равен - {FindMinRow(array)} строке.");
