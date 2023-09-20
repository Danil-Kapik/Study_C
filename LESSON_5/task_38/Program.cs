// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//            между максимальным и минимальным элементов массива.


using System;

class Program
{
    static void Main()
    {
        double[] numbers = { 5.5, 2.3, 8.7, 1.2, 9.8, 3.6, -1};
        double minNumber = numbers[0];
        double maxNumber = numbers[0];

        foreach (double number in numbers)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }

            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        double difference = maxNumber - minNumber;
        Console.Clear();
        Console.WriteLine("Минимальный элемент: " + minNumber);
        Console.WriteLine("Максимальный элемент: " + maxNumber);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }
}
