//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int getSumm(int num)
{
    int summ = 0;
    while (num != 0)
    {
        summ += num % 10;
        num /= 10;
    }

    return summ;
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"Сумма цифр в числе - {getSumm(n)}");
