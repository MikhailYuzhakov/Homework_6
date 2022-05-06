/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int i = 0;
int[] array = new int[1000];

Console.Clear();
Console.WriteLine("Введите M чисел с клавиатуры через пробел: ");

int[] mas = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int j = 0; j < mas.Length; j++) if (mas[j] > 0) i++;

Console.WriteLine($"Количество положительных чисел = {i}");