int[,] fillArrayRandom(int m, int n)
{
    int[,] tempArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[i, j] = new Random().Next(0, 100);
        }
    }
    return tempArray;
}

void printArray(int[,] arr)
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


void printAverage(int[,] arr)
{
    
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    Console.Write("Среднее арифметическое строк массива: " );
    for (int i = 0; i < m; i++)
    {
        double rowSum = 0;
        for (int j = 0; j < n; j++)
        {
            rowSum += arr[i,j];
        }
        double res = rowSum / n;
        Console.Write(Math.Round(res, 2) + " ");
 
    }
}


Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int [,] randArray = fillArrayRandom(m, n);
printArray(randArray);
printAverage(randArray);