/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите число: ");
int nDay = int.Parse(Console.ReadLine());

if (nDay>0 & nDay<8)
{
    if (nDay == 6 | nDay == 7)
    {
        Console.WriteLine("Да, сегодня Выходной!");
    }
    else Console.WriteLine("Нет, ещё работаем ;)");
}
else Console.WriteLine("Это цифра не соответствует дню недели!");
