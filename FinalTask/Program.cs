/* 
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
//Решение задачи без метода
// string[] array = new string[] { "Hello", "2", "world", ":-)" };
// string[] newArray = new string[array.Length];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i].Length < 4)
//     {
//         newArray[i] = array[i];

//     }
// }

// for (int i = 0; i < newArray.Length; i++)
// {
//     Console.Write(newArray[i] + " ");
// }

//Решение задачи методом
Console.WriteLine("Введите любые 4 слова через Enter:");
string[] array = new string[4];
string[] newArray = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

Console.WriteLine("Массив до сортировки:");
PrintArray(array);
Console.WriteLine("Массив после сортировки:");
SortArray(array, newArray);
PrintArray(newArray);

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SortArray(string[] arr, string[] newArr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newArr[i] = arr[i];
        }
    }
}