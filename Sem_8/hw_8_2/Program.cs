//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void sortArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i=0; i<m; i++)
    {
        for(int j=0; j < m-1-i; j++)
        {
            if (array[j,1] > array[j+1,1]) 
            {
                (array[j,1], array[j+1,1]) = (array[j+1,1], array[j,1]);
                (array[j,0], array[j+1,0]) = (array[j+1,0], array[j,0]);
            }

        }
    }

    Console.Write("Номер строки с минимальной суммой чисел " + array[0,0]);
}

void findMinSumRow(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int[,] sumRowArray = new int[m,2];
    for (int i=0; i<m; i++)
    {
        int rowSum = 0;
        for (int j=0; j<n; j++)
        {
            rowSum += array[i,j];
        }
        sumRowArray[i,1] = rowSum;
        sumRowArray[i,0] = i;
    }
    
    Console.WriteLine("Номер строки и сумма чисел в ней:");
    
    printArray(sumRowArray);
    sortArray(sumRowArray); 
}

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

Console.Clear();
int[,] newArray = fillArrayRandom(4,4);

Console.WriteLine("Исходный массив:");
printArray(newArray);

findMinSumRow(newArray);