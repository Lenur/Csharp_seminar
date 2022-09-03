/* 
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
// Метод создания двумерного массива по часовой стрелке
int[,] SpiralArrayClockwise(int m, int n)
{
    int[,] matrix = new int[m, n];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = n;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = n * (dirChanges % 2) + m * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
    return matrix;
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

Console.Write("Введите количество строк - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = SpiralArrayClockwise(rows, columns);
PrintArray(array);

//-----------------------------------------------
// решение взято с форума www.cyberforum.ru
// const int n = 5;
// const int m = 5;
// int[,] matrix = new int[n, m];

// int row = 0;
// int col = 0;
// int dx = 1;
// int dy = 0;
// int dirChanges = 0;
// int visits = m;

// for (int i = 0; i < matrix.Length; i++)
// {
//     matrix[row, col] = i + 1;
//     if (--visits == 0)
//     {
//         visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//         int temp = dx;
//         dx = -dy;
//         dy = temp;
//         dirChanges++;
//     }

//     col += dx;
//     row += dy;
// }
