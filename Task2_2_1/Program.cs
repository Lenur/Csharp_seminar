/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
*/

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

string stringNumber = Convert.ToString(number);
if (stringNumber.Length == 3)
    Console.WriteLine($"Последняя цифра трехзначного числа равна {stringNumber[2]}");
else
    Console.WriteLine("Увы это не трёхзначное число!");