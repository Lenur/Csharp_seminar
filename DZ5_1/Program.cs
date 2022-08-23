/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//Метод заполнения массива случайными положительными трёхзначными числами
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 1000);
    }
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];   //размер массива
int countEven = 0;      //количесвто четных чисел
FillArray(array);

Console.WriteLine("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        countEven++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно {countEven}");