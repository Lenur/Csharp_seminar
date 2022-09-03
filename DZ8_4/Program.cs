/* 
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */
// Метод создания трехмерного массива, рандомными числами
int[,,] GetArray(int m, int n, int z, int min, int max)
{
    int[,,] result = new int[m, n, z];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return result;
}
// Метод вывода трехмерного массива
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)  // цикл для уровней (planes)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)  // цикл для строк (rows)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)  // цикл для столбцов (columns)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
                //plane, row, column
int[,,] array = GetArray(2, 2, 3, 10, 100);
PrintArray(array);
