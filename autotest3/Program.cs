using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
       for (int start = 1; start <= N; start++)
{
    //int cube = Math.Pow(start, 3)
    Console.WriteLine($"{Math.Pow(start, 3)}"); 
    }
   }
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}