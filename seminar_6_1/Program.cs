// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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