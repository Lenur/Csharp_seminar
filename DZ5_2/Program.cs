/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//Метод заполнения массива случайными числами
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
        sum += array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива равна {sum}");