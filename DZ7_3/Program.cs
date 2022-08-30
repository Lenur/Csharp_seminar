/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

int[,] matrix = new int[4, 4];
GetMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
ArithMeanColumns(matrix);


// Метод создания двумерного массива из целых чисел.
void GetMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

// Метод вывода массива.
void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]}");
        }
        Console.WriteLine();
    }
}

// Метод нахождения среднее арифметического элемента в каждом столбце.
void ArithMeanColumns(int[,] inArray)
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[j, i]; //находим сумму всех элементов столбца
        }
        average = sum / inArray.GetLength(1);
        Console.Write($" {average:f1}");
        sum = 0;
    }
}