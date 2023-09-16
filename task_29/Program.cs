// Задача 29: Напишите программу, которая задаёт массив 
//            из 8 элементов и выводит их на экран.


using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Random random = new Random();
        int[] numbers = new int[8];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }
        Console.WriteLine("Элементы массива:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}