/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
if (IsPalindrome(num))
{
    Console.WriteLine("Да, это число палиндром!");
}
else Console.WriteLine("Нет!");

//функция которая проверяет число, является ли число палиндромом
static bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}