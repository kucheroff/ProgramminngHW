//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double getPow(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.Clear();
Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write($"{n1} в степени {n2} равно {getPow(n1, n2)}");
