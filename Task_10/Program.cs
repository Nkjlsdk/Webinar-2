﻿// Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число: {number}");
Console.WriteLine($"Вторая цифра числа {number%100/10}");
