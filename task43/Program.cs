//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Пересечение прямых задаётся уравнением: k1 * x + b1 = k2 * x + b2,
// -> можно найти х:  x = (b2 - b1) / (k1 - k2).

Console.WriteLine("Последовательно введите значения k1, b1, k2, b2:");
double k1 = int.Parse(Console.ReadLine()), b1 = int.Parse(Console.ReadLine());
double k2 = int.Parse(Console.ReadLine()), b2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"( {x} ; {y} )");