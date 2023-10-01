// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//            которая будет находить строку с наименьшей суммой элементов.
//            Программа считает сумму элементов в каждой строке и выдаёт номер 
//            строки с наименьшей суммой элементов: 1 строка


using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        int cols = 3;

        int[,] array = GenerateRandomArray(rows, cols);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        int minRow = FindMinSumRow(array);
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRow + 1}");
    }

    static int[,] GenerateRandomArray(int rows, int cols)
    {
        Random random = new Random();
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 100);
            }
        }
        return array;
    }

    static int FindMinSumRow(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < cols; j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minRow = i;
            }
        }

        return minRow;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
