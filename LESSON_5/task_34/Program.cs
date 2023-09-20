// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//            числами. Напишите программу, которая покажет количество чётных 
//            чисел в массиве.


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
            array[i] = random.Next(100, 1000);
        }
        return array;
    }

    static int EvenNumber(int[] array)
    {
        int numCount = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                numCount++;
            }
        }
        return numCount;
    }

    static void Main()
    {
        Console.Clear();
        int length = Prompt("Введите длину массива: ");
        int[] array = GenerateArray(length);
        int evenCount = EvenNumber(array);

        System.Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++){
            System.Console.Write($"{array[i]}, ");
        }
        System.Console.Write($"{array[array.Length - 1]}]\n");
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }
}

