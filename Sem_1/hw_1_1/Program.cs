Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
    Console.Write($"Первое число {a} больше второго числа {b}.");
else
    Console.Write($"Второе число {b} больше первого числа {a}.");
