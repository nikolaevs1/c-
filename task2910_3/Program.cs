// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите количество элементов массива: "); // на вырост :)
// int number = Convert.ToInt32(Console.ReadLine());

int number = 8; // кол-во элементов массива
int[] diapason = {-10, 10}; // в условиях диапазон элементов не указан, задаем здесь

int[] array = GetArray(number);
Console.WriteLine($"Массив из {number} элементов: [{String.Join(", ", array)}]");


int[] GetArray(int size)
{
    int[] arr = new int[size]; 
    for (int i = 0; i < size; i++) 
    {
        arr[i] = new Random().Next(diapason[0], diapason[1]);
    }
    return arr;
}