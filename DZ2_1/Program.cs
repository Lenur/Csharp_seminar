/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int num = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число: {num}");

// Математический метод
// int secondNum = num/10%10;
// Console.WriteLine($"Вторая цифра этого числа равна {secondNum}");

//Метод ToSrirng
string secondNum = Convert.ToString(num);
Console.WriteLine($"Вторая цифра этого числа равна {secondNum[1]}");