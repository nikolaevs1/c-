// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
double Stepen (int A, int B) // double выбран для того, чтобы поддержать работу с отрицательными степенями
{
    double step1 = 1;
    double step;
    for (int i = 1; i <= Math.Abs(B); i++)
    {
        step1 = step1 * A;
    }
    
    if (B<0)
        {
           step = 1 / step1; 
        }
        else step = step1;
    return step;
}

System.Console.WriteLine($"Расчет через цикл: {A} в степени {B} равно {Stepen(A,B)}");
System.Console.WriteLine($"Расчет через математическую функцию: {A} в степени {B} равно {Math.Pow (A,B)}");