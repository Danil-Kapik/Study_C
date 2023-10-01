// Задача 66: Задайте значения M и N. Напишите программу, которая 
//            найдёт сумму натуральных элементов в промежутке от M до N.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M > N)
        {
            Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
        }
        else
        {
            int sum = CalculateSum(M, N);
            Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}: {sum}");
        }
    }

    static int CalculateSum(int start, int end)
    {
        if (start > end)
        {
            return 0;
        }
        else
        {
            return start + CalculateSum(start + 1, end);
        }
    }
}
