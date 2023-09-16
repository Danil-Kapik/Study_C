// Задача 27: Напишите программу, которая принимает на 
//            вход число и выдаёт сумму цифр в числе.


using System;


class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите число:");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            int result = SumOfDigits(n);
            Console.WriteLine($"Сумма цифр числа {n} = {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное число n.");
        }
    }

    static int SumOfDigits(int n)
    {
        int sum = 0;
        n = Math.Abs(n);
        for (; n > 0; n /= 10)
        {
            int digit = n % 10;
            sum += digit;
        }

        return sum;
    }
}