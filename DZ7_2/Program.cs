/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
 */
Console.Write("Введите позицию элемента в двумерном массиве через ПРОБЕЛ: ");
string poz = Convert.ToString(Console.ReadLine());
var pozElement = poz.Split(' '); //подстрочное взятие позиции элемента из вводимой строки
int rowPozElement = Convert.ToInt32(pozElement[0]);
int columnPozElement = Convert.ToInt32(pozElement[1]);

int[,] matrix = new int[3, 3];
GetMatrix(matrix);
PrintMatrix(matrix);
FindElement(matrix, rowPozElement, columnPozElement);

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

// Метод нахождения заданного  элемента в массиве.
void FindElement(int[,] inArray, int m, int n)
{
    int rows = inArray.GetLength(0);
    int columns = inArray.GetLength(1);
    if (m < rows && n < columns) Console.WriteLine($"Найденный элемент массива равен {inArray[m, n]}");
    else Console.WriteLine("Такого элемента в массиве НЕТ!");
}