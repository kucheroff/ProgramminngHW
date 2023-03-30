//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void fillArraySpiral(int[,] array)
{
    int m = 0;
    int n = 0;
    int direction = 1;
    array[m,n] = 1;
    for (int i=2; i<array.Length+1; i++)
    {
        if (n + 1 < array.GetLength(1) && array[m, n + 1] == 0 && direction == 1)
        {
            array[m, n + 1] = i;
            n++;
            continue;
        }
        direction = 2;
        if (m + 1 < array.GetLength(0) && array[m+1, n] == 0 && direction == 2)
        {
            array[m+1, n] = i;
            m++;
            continue;
        }
        direction = 3;
        if (n > 0 && array[m, n -1] == 0 && direction == 3)
        {
            array[m, n - 1] = i;
            n--;
            continue;
        }
        direction = 4;
        if (m > 0 && array[m-1, n] == 0 && direction == 4)
        {
            array[m-1, n] = i;
            m--;
            continue;
        }
        direction = 1;
        n++;
        array[m,n] = i;
    }
}


void printArray(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i,j].ToString().PadLeft(2,'0')}\t");
        }
        Console.WriteLine();
    }
}

int[,] arr = new int[5,5];   //размер массива может быть любым

fillArraySpiral(arr);
Console.Clear();
printArray(arr);