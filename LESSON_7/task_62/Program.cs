// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//            Например, на выходе получается вот такой массив:


using System;

class Program
{
    static void Main()
    {
        int[,] array = GenerateSpiralArray(5, 5);

        PrintArray(array);
    }

    static int[,] GenerateSpiralArray(int rows, int cols)
    {
        int[,] array = new int[rows, cols];

        int currentValue = 1;
        int startRow = 0, endRow = rows - 1;
        int startCol = 0, endCol = cols - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            for (int i = startCol; i <= endCol; i++)
            {
                array[startRow, i] = currentValue++;
            }
            startRow++;

            for (int i = startRow; i <= endRow; i++)
            {
                array[i, endCol] = currentValue++;
            }
            endCol--;

            for (int i = endCol; i >= startCol; i--)
            {
                array[endRow, i] = currentValue++;
            }
            endRow--;

            for (int i = endRow; i >= startRow; i--)
            {
                array[i, startCol] = currentValue++;
            }
            startCol++;
        }

        return array;
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

