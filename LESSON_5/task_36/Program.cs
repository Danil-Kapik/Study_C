// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.


using System;

class Program
{
    static int Prompt(string message)
    {
        Console.Write(message);
        string readInput = Console.ReadLine();
        int result;
        
        if (int.TryParse(readInput, out result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
            return Prompt(message);
        }
    }

    static int[] GenerateArray(int length)
    {
        int[] array = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 100);
        }
        return array;
    }

    static int SumOfOddPositionElements(int[] array)
    {
        int positionElements = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            positionElements += array[i];
        }
        return positionElements;
    }

    static void Main()
    {
        Console.Clear();
        int length = Prompt("Введите длину массива: ");
        int[] array = GenerateArray(length);
        int evenSumElem = SumOfOddPositionElements(array);

        System.Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++){
            System.Console.Write($"{array[i]}, ");
        }
        System.Console.Write($"{array[array.Length - 1]}]\n");
        Console.WriteLine($"Сумма четных элементов равна: {evenSumElem}");
    }
}
