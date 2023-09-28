// Задача 54: Задайте двумерный массив. Напишите программу, которая 
//            упорядочит по убыванию элементы каждой строки двумерного массива.


using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        int cols = 5;

        int[,] array = GenerateRandomArray(rows, cols);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        OrderRowsDescending(array);

        Console.WriteLine("\nУпорядоченный массив:");
        PrintArray(array);
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

    static void OrderRowsDescending(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = array[i, j];
            }
            Array.Sort(row, (a, b) => b.CompareTo(a));

            for (int j = 0; j < cols; j++)
            {
                array[i, j] = row[j];
            }
        }
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
