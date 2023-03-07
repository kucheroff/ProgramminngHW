//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] fillArray(string pointName)
{
    int[] tmp = new int[3];
    
    Console.Clear();
    Console.WriteLine($"Точка {pointName}.");
    Console.Write("Введите координату x : ");
    tmp[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите координату y : ");
    tmp[1] = int.Parse(Console.ReadLine());
    Console.Write("Введите координату z : ");
    tmp[2] = int.Parse(Console.ReadLine());
    Console.Clear();

    return tmp;
}

double getDistance(int[] point_1, int[] point_2)
{
    double result = Math.Sqrt(Math.Pow(point_1[0] - point_2[0] , 2)+ Math.Pow(point_1[1] - point_2[1] , 2) + Math.Pow(point_1[2] - point_2[2], 2));
    
    return Math.Round(result,2,MidpointRounding.ToNegativeInfinity);
}

int[] a = fillArray("A");
int[] b = fillArray("B");

Console.Write($"Расстояние между точками с координатами {a[0]},{a[1]},{a[2]} и {b[0]},{b[1]},{b[2]} составляет {getDistance(a, b)}");

