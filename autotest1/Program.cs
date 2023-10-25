using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
      if (number >= 10000 && number < 100000)
{
    int firstDigit = number / 10000;
    int lastDigit = number % 10;
    int secondDigit = (number /1000)%10;
    int forthDigit = number /10 %10;
    if (firstDigit == lastDigit && secondDigit == forthDigit)
    {
        System.Console.Write($"{number} -> ");
        return true;
    }
        else
        {
            System.Console.Write($"{number} -> ");
            return false;
        }
        
}
else 
{
Console.WriteLine($"{number} -> Число не пятизначное");
return false;
}



      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}