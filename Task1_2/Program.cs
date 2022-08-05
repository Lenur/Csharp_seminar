/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
*/

Console.Write("Введите номер: ");
int nDay = int.Parse(Console.ReadLine());

if (nDay==1)
    Console.WriteLine("Понедельник");
if (nDay==2)
    Console.WriteLine("Вторник");
if (nDay==3)
    Console.WriteLine("Среда");
if (nDay==4)
    Console.WriteLine("Четверг");
if (nDay==5)
    Console.WriteLine("Пятница");
if (nDay==6)
    Console.WriteLine("Суббота");
if (nDay==7)
    Console.WriteLine("Воскресенье");
if ((nDay<1) | (nDay>7))
    Console.WriteLine("Этот номер не соответствует дню недели!");