// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5
Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [m];
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите число {i+1}: ");
    numbers [i] = Convert.ToInt32 (Console.ReadLine());
    if (numbers[i]>0)
    {
        count+=1;
    }

}
PrintArray(numbers);
Console.WriteLine($"Колличество чисел больше 0: {count}");


static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
Console.WriteLine($"[{String.Join("\t", array)}]");

    }