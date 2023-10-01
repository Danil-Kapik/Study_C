// Задача 64: Задайте значение N. Напишите программу, которая 
//            выведет все натуральные числа в промежутке от N до 1. 
//            Выполнить с помощью рекурсии.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());
        PrintNaturalNumbers(N);
    }

    static void PrintNaturalNumbers(int N)
    {
        if (N >= 1)
        {
            Console.Write(N + " ");
            PrintNaturalNumbers(N - 1);
        }
    }
}
