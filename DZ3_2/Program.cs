/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
// string str = "Слово1#Слово2#Слово3";
// var str2 = str.Split('#');
// Console.WriteLine(str2[0]);
// Console.WriteLine(str2[1]);
// Console.WriteLine(str2[2]);

Console.WriteLine("Введите координаты точки А: ");
string axyz = Console.ReadLine();
var aCoor = axyz.Split(','); //подстрочное взятие координаты точки А из вводимой строки

double xaCoor = Convert.ToDouble(aCoor[0]); //перевод из строкового типа  в тип double координаты х точки А
double yaCoor = Convert.ToDouble(aCoor[1]); //перевод из строкового типа  в тип double координаты y точки А
double zaCoor = Convert.ToDouble(aCoor[2]); //перевод из строкового типа  в тип double координаты z точки А

Console.WriteLine("Введите координаты точки В: ");
string bxyz = Console.ReadLine();
var bCoor = bxyz.Split(','); //подстрочное взятие координаты точки В из вводимой строки

double xbCoor = Convert.ToDouble(bCoor[0]); //перевод из строкового типа  в тип double координаты х точки B
double ybCoor = Convert.ToDouble(bCoor[1]); //перевод из строкового типа  в тип double координаты y точки B
double zbCoor = Convert.ToDouble(bCoor[2]); //перевод из строкового типа  в тип double координаты z точки B

//формула вычисления расстояния между двумя точками в 3D пространстве
double ab = Math.Sqrt(Math.Pow(xbCoor - xaCoor, 2) + Math.Pow(ybCoor - yaCoor, 2) + Math.Pow(zbCoor - zaCoor, 2));
Console.WriteLine($"Расстояние между точками А({axyz}) и В({bxyz}) равно {ab:f2}");