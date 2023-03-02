﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

// На всякий случай для отрицательных чисел тоже будет считать
if (a < 100 & a > -100) Console.Write($"В числе {a} отсутствует третья цифра");    
else
{
    if (a < 0) a *= -1;
    while (a < 100 | a > 999) a /= 10;
    Console.Write($"Третья цифра во введенном числе - {a % 10}");
}