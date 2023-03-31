//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int printSum(int m, int n)
{
    if (m>n) return 0;
    m += printSum(m+1, n);
    return m;
}

Console.Clear();
Console.Write($"{printSum(1, 15)}");