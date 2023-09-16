// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//            и возводит число A в натуральную степень B.


using System;


class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите число A:");
        if (double.TryParse(Console.ReadLine(), out double A))
        {
            Console.WriteLine("Введите натуральное число B:");
            if (int.TryParse(Console.ReadLine(), out int B) && B >= 0)
            {
                double result = DegreeNumber(A, B);
                Console.WriteLine($"{A}^{B} = {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное число B.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное число A.");
        }
    }

    static double DegreeNumber(double A, int B)
    {
        double result = 1.0;

        for (int i = 0; i < B; i++)
        {
            result *= A;
        }

        return result;
    }
}