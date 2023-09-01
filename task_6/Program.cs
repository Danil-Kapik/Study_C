// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//           является ли число чётным (делится ли оно на два без остатка)


Console.WriteLine("Введите целое число:");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"Число {number} является четным!");
    }
    else
    {
    Console.WriteLine("Ошибка: Число не является четным!");
    }
}
else
{
    Console.WriteLine("Ошибка: Введите корректное число.");
}
