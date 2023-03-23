double[,] fillArrayRandom(int m, int n)
{
    double[,] tempArray = new double[m, n];
    int max =10;
    int min = -10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[i, j] = Math.Round((new Random().NextDouble()* (max-min)+min),1);
        }
    }
    return tempArray;
}

void printArray(double[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
double [,] randArray = fillArrayRandom(m, n);
printArray(randArray);
