// Задача 8: Напишите программу, которая на вход принимает число (N), 
//           а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число n:");
if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
{
    Console.WriteLine("Четные числа от 1 до n:");

    for (int i = 2; i <= n; i += 2)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.WriteLine("Ошибка: Введите корректное положительное число.");
}