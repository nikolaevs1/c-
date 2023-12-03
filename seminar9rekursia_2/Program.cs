// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    Console.Write("Число M не должно быть больше N");
}
else
{
    Console.WriteLine(PrintSumm(M, N));
}


int PrintSumm(int start, int end)
{
    // Базовый случай
    if (start == end) return start;
    // Рекурсивный случай
    return (start + PrintSumm(start + 1, end));
}

