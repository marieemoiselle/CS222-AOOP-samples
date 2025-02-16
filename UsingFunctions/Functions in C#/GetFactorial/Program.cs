using System;

class Program {
    static int Factorial(int n) {
        if (n == 0)  // Base case: factorial of 0 is 1
            return 1;
        else  // Recursive case: n * factorial of (n-1)
            return n * Factorial(n - 1);
    }

    static void Main() {
        int num = 10;
        Console.WriteLine($"Factorial of {num} is: {Factorial(num)}");
    }
}