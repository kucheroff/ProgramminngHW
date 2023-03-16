int[] fillArray(int num)
{
    int[] mass = new int[num];
    for(int i=0; i<num; i++)
    {
        mass[i] = new Random().Next(-100, 101);
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
    return mass;

}


void printNumPos(int[] arr)
{
    int result = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (i % 2 != 0) result += arr[i];
    }
    Console.Write($"Сумма элементов на нечетных местах в массиве {result}");
}

Console.Clear();
printNumPos(fillArray(5));