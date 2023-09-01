// Задача 2: Напишите программу, которая на вход принимает два 
//           числа и выдаёт, какое число большее, а какое меньшее.
 

Console.WriteLine("Введите первое число:");
if (double.TryParse(Console.ReadLine(), out double number1))
{
    Console.WriteLine("Введите второе число:");
    if (double.TryParse(Console.ReadLine(), out double number2))
    {
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} больше, чем {number2}");
        }
        else if (number1 < number2)
        {
            Console.WriteLine($"{number1} меньше, чем {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} и {number2} равны.");
        }
    }
    else
    {
        Console.WriteLine("Ошибка: Введите корректное второе число.");
    }
}
else
{
    Console.WriteLine("Ошибка: Введите корректное первое число.");
}

