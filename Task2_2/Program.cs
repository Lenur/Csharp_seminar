/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
*/

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (((-1000<number) & (number<-99)) | ((number>99) & (number<1000)))
{
    int i=Math.Abs(number%100%10);
    Console.WriteLine($"Последняя цифра трехзначного числа равна {i}");
}
else 
{
    Console.WriteLine("Увы это не трёхзначное число!");
}