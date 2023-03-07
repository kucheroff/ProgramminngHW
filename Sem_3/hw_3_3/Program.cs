 //Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 
void showCubes(int num)
{
    for (int i = 1; i <= num -1; i++)
        Console.Write($"{Math.Pow(i, 3)}, "); //до последнего числа ставим запятую после каждого числа
    Console.Write($"{Math.Pow(num, 3)}."); //после последнего числа ставим точку.
}

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

showCubes(n);
