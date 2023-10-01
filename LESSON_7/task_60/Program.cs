// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
//               чисел. Напишите программу, которая будет построчно выводить 
//               массив, добавляя индексы каждого элемента.
//               Массив размером 2 x 2 x 2


using System;

class Program
{
    static void Main()
    {
        int xSize = 2;
        int ySize = 2;
        int zSize = 2;

        int[,,] array = GenerateUniqueTwoDigitArray(xSize, ySize, zSize);
        PrintArrayWithIndices(array);
    }

    static int[,,] GenerateUniqueTwoDigitArray(int xSize, int ySize, int zSize)
    {
        Random random = new Random();
        int[,,] array = new int[xSize, ySize, zSize];
        bool[] usedNumbers = new bool[100];

        for (int i = 0; i < xSize; i++)
        {
            for (int j = 0; j < ySize; j++)
            {
                for (int k = 0; k < zSize; k++)
                {
                    int randomNumber;
                    do
                    {
                        randomNumber = random.Next(10, 100);
                    } while (usedNumbers[randomNumber]);

                    array[i, j, k] = randomNumber;
                    usedNumbers[randomNumber] = true;
                }
            }
        }

        return array;
    }

    static void PrintArrayWithIndices(int[,,] array)
    {
        int xSize = array.GetLength(0);
        int ySize = array.GetLength(1);
        int zSize = array.GetLength(2);

        for (int i = 0; i < xSize; i++)
        {
            for (int j = 0; j < ySize; j++)
            {
                for (int k = 0; k < zSize; k++)
                {
                    Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
                    
                }
                Console.Write('\n');
            }
        }
    }
}

