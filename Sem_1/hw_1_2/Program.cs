Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max_num = a;

if (b > max_num) max_num = b;
if (c > max_num) max_num = c;

Console.Write($"Из чисел {a}, {b}, {c} максимальное число {max_num}.");
