// Задача со звездочкой Найти второй максимум в массиве.
// Кактотак.....

int[] array = new int[] {4,4,3,0,2};

int max1 = array[0];
int max2 = array[1];

if (max2 > max1)
    {
        (max1, max2) = (max2, max1);
    }

for (int i=2; i<array.Length; i++)
{
    if (array[i]> max1)
    {
        (max1, max2) = (max2, max1);
        max1 = array[i];
    }
    else if (max1 == max2) 
    {
        max2 = array[i];
    } 
    else if(array[i]< max1 && array[i]> max2)
    {
         max2 = array[i];
    }
}

Console.Clear();
Console.Write($"max1 = {max1} , max2 = {max2}");