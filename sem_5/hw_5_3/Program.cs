int[] fillArray(int num)
{
    int[] mass = new int[num];
    for(int i=0; i<num; i++)
    {
        mass[i] = new Random().Next(0, 100);
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
    return mass;

}


void printDiff(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i=1; i<arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i]< min) min = arr[i];
    }

    Console.Write($"Разница между минимальным и максимальнм элементом массива {max} -  {min} = {max - min}");
}

Console.Clear();
printDiff(fillArray(5));