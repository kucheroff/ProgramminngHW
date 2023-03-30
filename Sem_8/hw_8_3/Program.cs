int[,] fillArrayRandom(int m, int n)
{
    int[,] tempArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[i, j] = new Random().Next(1, 5);
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

void MultMatrix(int[,] arrayA, int[,] arrayB)
{

    int m= arrayA.GetLength(0);
    int n = arrayA.GetLength(1);
    int p = arrayB.GetLength(0);
    int[,] arrayC = new int[m, n];
    
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
        int e=0;
           for (int k = 0; k<p; k++)
           {
                e += (arrayA[i,j] * arrayB[k ,i]);
           }
           arrayC[i,j] = e;
        }
    }
    printArray(arrayC);
}

Console.Write("Количество строк матрицы А: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов матрицы А: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Количество строк матрицы B: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов матрицы B: ");
int n2 = int.Parse(Console.ReadLine());

int[,] matA = fillArrayRandom(m1, n1);
int[,] matB = fillArrayRandom(m2, n2);

Console.Clear();
Console.WriteLine("Матрица А");
printArray(matA);
Console.WriteLine("Матрица B");
printArray(matB);
if (m2 != n1) Console.Write("Нельзя перемножить матрицы.");
else
{
    Console.WriteLine("Матрица C");
    MultMatrix(matA, matB);
}

