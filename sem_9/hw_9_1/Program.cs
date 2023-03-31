// Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.

void printEven(int m, int n)
{
    if (m > n) return;
    
    if (m % 2 == 0) Console.Write(m + " ");

    printEven(m+1,n);
}

Console.Clear();
printEven(5, 19);