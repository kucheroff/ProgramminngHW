// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int getAK(int m, int n)
{
  if (m == 0)
    return n + 1;
  else if ((m != 0) && (n == 0))
      return getAK(m - 1, 1);
  else
      return getAK(m - 1, getAK(m, n - 1));
}

Console.Clear();
Console.Write(getAK(3,2));