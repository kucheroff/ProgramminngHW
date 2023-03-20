int numPositive(int[] mass)
{
    int  result = 0;
    for (int i=0; i< mass.Length; i++) if (mass[i] > 0) result += 1;
    return result;

}

Console.Clear();
Console.WriteLine("Введите числа массива через пробел:");
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write("Количество чисел больше нуля " + numPositive(arr));
