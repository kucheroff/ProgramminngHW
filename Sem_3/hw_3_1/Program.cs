   //Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
   
   void isPolindrome_ver1(string num)
    {
        
        bool isPoly = true;

        for (int i = 0; i < num.Length / 2; i++)
        {
            if (num[i] != num[num.Length - 1 - i])
             {
                isPoly = false;
                break;
            }
        }

        Console.WriteLine("Метод 1.");
        if (isPoly) Console.WriteLine("Число является полиндромом.");
        else Console.WriteLine("Число не является полиндромом.");
    }
    
    void isPolindrome_ver2(int num)
    {
       int num_orig = num;
       int num_rev = 0; 
       while (num_orig > 0)
        {
           num_rev = num_rev * 10 + num_orig % 10;
           num_orig /= 10;
        }

        Console.WriteLine("Метод 2.");
        if (num == num_rev) Console.WriteLine("Число является полиндромом.");
        else Console.WriteLine("Число не является полиндромом.");
    }


    Console.Clear();
    Console.Write("Введите целое число: ");
    string numSource_1 = (Console.ReadLine());
    int numSource_2 = (int.Parse(numSource_1));
    
    isPolindrome_ver1(numSource_1);
    isPolindrome_ver2(numSource_2);