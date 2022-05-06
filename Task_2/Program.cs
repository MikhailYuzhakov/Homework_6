/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.Clear();
Console.WriteLine("Введите значения b1, k1, b2, k2 через пробел: ");

double[] mas = Console.ReadLine().Split().Select(double.Parse).ToArray();

double x = (mas[2] - mas[0]) / (mas[1] - mas[3]); //x = (b2 - b1) / (k1 - k2)
double y = mas[1] * x + mas[0]; //y = k1 * x + b1

Console.WriteLine("Точка пересечения двух прямых: (" + x + ", " + y + ")");


