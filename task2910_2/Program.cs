// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int SumDigit (int z)
{
    int sum = 0;
    for (int count=1; z/count > 1; count *=10)
    {
        int digit = z/count%10;         
        sum = sum + digit;
        // Console.WriteLine($"{digit}"); // использовал для отладки
    }


return sum;
}
System.Console.WriteLine($"Сумма цифр в числе {A} равна {SumDigit(A)}");