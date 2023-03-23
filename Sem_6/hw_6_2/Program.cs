int numPositive(int[] mass)
{
    int  result = 0;
    for (int i=0; i< mass.Length; i++) if (mass[i] > 0) result += 1;
    return result;

}

Console.Clear();
Console.WriteLine("Введите значения коэффициентов k1, b1, k2, b2 для уравнений y = k1 * x + b1, y = k2 * x + b2 :");
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

double y = arr[2] * ((y-arr[1]/arr[0])) + arr[3];

//Console.Write("Количество чисел больше нуля " + numPositive(arr));