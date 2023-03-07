//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] fillArray()
{
    int[] result = new int[8];
    for (int i = 0; i < 8; i++)
    {   
        Console.Write($"Введите элемент массива с индексом {i}: ");
        result[i] = int.Parse(Console.ReadLine());
    }

    return result;
}

void printArray(int [] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length-1]}]");
}

Console.Clear();
printArray(fillArray());


