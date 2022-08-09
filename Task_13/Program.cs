// Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = new Random().Next(10,1000);
Console.WriteLine($"Случайное число: {number}");
if (number/100 == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {number%10}");
}
