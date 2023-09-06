// Задача 13: Напишите программу, которая выводит третью цифру 
//            заданного числа или сообщает, что третьей цифры нет.



Console.WriteLine("Введите число:");
string str = Console.ReadLine();
if (str != null && str.Length >= 3 && int.TryParse(str, out int n))
{
    Console.WriteLine($"Введенное число - {str}");
    Console.Write($"Третья цифра этого числа = {str[2]}");
}
else
{
    Console.WriteLine($"Ошибка: Третьей цифры нет -- {str}");
}
