/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

//Метод заполнения массива вещественными числами
void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
    }
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double raz = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементом массива равна {raz}");