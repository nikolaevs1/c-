// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 < 1)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else 
{
    int count =1;
while ( (number/count) > 1000)
{
    count *=10;
}
Console.WriteLine($"{count}");
int threeDigit = (number / count) % 10;
Console.WriteLine($"{number} -> {threeDigit}");
}

