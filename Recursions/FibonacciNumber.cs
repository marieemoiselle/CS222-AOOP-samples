using System;

int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

Console.Write("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());

int value = Fibonacci(x);
Console.WriteLine($"Fibonacci value at position{x}: {value}");
