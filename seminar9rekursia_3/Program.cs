// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(n,m) = 29


// сделал по псевдокоду из википедии. Механика вызова методов понятна, но математический смысл функции Аккермана - не понял

int n = 3;
int m = 2;

int result = AckFunc(n, m);
Console.WriteLine($"A({n}, {m}) = {result}");


static int AckFunc(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AckFunc(n - 1, 1);
    }
    else
    {
        return AckFunc(n - 1, AckFunc(n, m - 1));
    }
}

