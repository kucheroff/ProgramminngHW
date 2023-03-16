int[] fillArray(int num)
{
    int[] mass = new int[num];
    for(int i=0; i<num; i++)
    {
    mass[i] = new Random().Next(100, 1000);
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
    return mass;

}


void printNum(int[] arr)
{
    int result = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0) result ++;
        
    }
    Console.Write($"Количество четных элементов в  массиве {result}");
}

Console.Clear();
printNum(fillArray(5));