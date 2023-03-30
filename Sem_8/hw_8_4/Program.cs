//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] create3DRandomArray(int x, int y, int z)
{
    int[,,] my3DArray = new int[x,y,z];
    int[] tempArray = new int[x*y*z];

    for (int i=0; i<tempArray.Length; i++)
    {
        int n = new Random().Next(10, 100);
        while (checkArray(tempArray, n)) n = new Random().Next(10, 100);
        tempArray[i] = n;
    }

    Console.WriteLine("Одномерный массив из неповторяющихся двузначных чисел:");
    for (int b=0; b<tempArray.Length; b++) Console.Write(tempArray[b]+" ");
    Console.WriteLine();

    int j = 0;
    while (j<tempArray.Length-4)
    {
        for (int m=0; m<x; m++)
        {
            for (int n=0; n<y; n++)
            {
                for (int p=0; p<z; p++)
                {
                    my3DArray[m,n,p] = tempArray[j];
                    j++;
                }
            }
        }
    }
    return my3DArray;
}

void printArray(int[,,] array)
{
    Console.WriteLine("Трехмерный массив из неповторяющихся двузначных чисел:");

    for (int m=0; m<array.GetLength(0); m++)
    {
        for (int n=0; n<array.GetLength(1); n++)
        {
            for (int p=0; p<array.GetLength(2); p++)
            {
                Console.Write($"{array[m,n,p]}({m},{n},{p}) ");
            }
            Console.WriteLine();
        }
    }
}

bool checkArray(int[] array, int num)
{
    for (int i=0; i< array.Length; i++)
    {
        if (array[i] == num) return true;
          
    }
     return false;     
}


Console.Clear();
printArray(create3DRandomArray(3,3,3));

