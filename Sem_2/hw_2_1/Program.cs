﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a = 0;

while (a < 100 | a > 999)
{
    Console.Clear();
    Console.Write("Введите трехзначное число: ");
    a = int.Parse(Console.ReadLine());
}

a = a / 10 % 10;
Console.Write($"Вторая цифра во введенном числе - {a}");