﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение k1:");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b1:");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b2:");
double b2 = double.Parse(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны, нет точки пересечения.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
}

