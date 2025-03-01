using System;

class Program
{
    // Recursive function to calculate the sum of numbers divisible by 10 from 1 to n
    static int SumDivisibleByTen(int n)
    {
        if (n < 10) // Base case: No numbers divisible by 10
            return 0;
        
        if (n % 10 == 0)
            return n + SumDivisibleByTen(n - 10); // Add and recurse with previous multiple of 10
        else
            return SumDivisibleByTen(n - 1); // Skip non-multiples of 10
    }

    static void Main()
    {
        Console.Write("Enter an integer n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int result = SumDivisibleByTen(n);
            Console.WriteLine("Sum of numbers divisible by 10 from 1 to {0} is: {1:F2}", n, result);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}