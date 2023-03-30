//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void sortArray(int[,] array)
{
    for (int m =0; m<array.GetLength(0); m++)
    {
        int l_array = array.GetLength(1);
        for (int i=0; i<l_array; i++)
        {
            for(int j=0; j < l_array-i-1; j++)
            {
                if (array[m,j] < array[m,j+1]) (array[m,j], array[m,j+1]) = (array[m,j+1], array[m,j]);
            }
        }
    }
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

sortArray(newArray);

Console.WriteLine("Отсортированный по стокам массив:");
printArray(newArray);


