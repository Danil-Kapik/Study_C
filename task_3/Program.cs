// Задача 4: Напишите программу, которая принимает на вход 
//           три числа и выдаёт максимальное из этих чисел.

using System;
using System.Linq;

Console.WriteLine("Введите три числа через пробел:");
string input = Console.ReadLine();
string[] numbersAsStrings = input.Split(' ');

if (numbersAsStrings.Length == 3)
{
    if (int.TryParse(numbersAsStrings[0], out int number1) &&
        int.TryParse(numbersAsStrings[1], out int number2) &&
        int.TryParse(numbersAsStrings[2], out int number3))
    {
        int[] numbers = { number1, number2, number3 };
        int maxNumber = numbers.Max();
        Console.WriteLine($"Максимальное число: {maxNumber}");
    }
    else
    {
        Console.WriteLine("Ошибка: Введите корректные числа.");
    }
}
else
{
    Console.WriteLine("Ошибка: Введите ровно три числа, разделенных пробелами.");
}

