/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите любые 5 чисел: ");
int[] array = new int[5];
int count =0;
for (int i=0; i<5; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i=0; i<5; i++)
{
    if(array[i]>0) count++;
}
Console.WriteLine(count + " чисел больше нуля.");