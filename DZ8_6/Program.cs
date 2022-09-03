// Отсортировать нечетные столбцы массива по возрастанию.

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

void SortColumns(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j % 2 != 0) //проверка на нечетность
            {
                for (int k = 0; k < inArray.GetLength(0) - 1; k++) //проверка по количеству итераций
                {
                    if (inArray[k, j] > inArray[k + 1, j])
                    {
                        int tmp = inArray[k, j];
                        inArray[k, j] = inArray[k + 1, j];
                        inArray[k + 1, j] = tmp;
                    }
                }
            }
        }
    }
}

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
SortColumns(array);
PrintArray(array);
