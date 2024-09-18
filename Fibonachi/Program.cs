using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть номер числа Фібоначчі: ");
        int n = int.Parse(Console.ReadLine());

        int fib = Fibonacci(n);
        Console.WriteLine($"Число Фібоначчі {n} дорівнює {fib}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, temp;

        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}

