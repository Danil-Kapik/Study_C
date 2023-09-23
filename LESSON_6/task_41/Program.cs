// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите числа, разделенные пробелами: ");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');
        int positiveCount = 0;

        foreach (string numberString in numberStrings)
        {
            if (double.TryParse(numberString, out double number))
            {
                if (number > 0)
                {
                    positiveCount++;
                }
            }
        }

        Console.WriteLine($"Количество чисел больше нуля: {positiveCount}");
    }
}
