/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string thirdNum = Convert.ToString(Math.Abs(num));  //Защита от ошибок отрицательных чисел

if (thirdNum.Length > 2)    
{
    Console.WriteLine($"Третья цифра заданного числа равна {thirdNum[2]}");
}
else Console.WriteLine("Третьей цифры нет !");