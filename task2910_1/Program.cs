// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int Stepen (int A, int B)
{
    int step1 = 1;
    for (int i = 1; i <= B; i++)
    {
        step1 = step1 * A;
    }
    return step1;
}

System.Console.WriteLine($"Расчет через цикл - {A} в степени {B} равно {Stepen(A,B)}");
System.Console.WriteLine($"Расчет через математическую функцию - {A} в степени {B} равно {Math.Pow (A,B)}");