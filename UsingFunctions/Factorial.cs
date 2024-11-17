using System;

// static factorial method
int factorial(int n)
{
    if (n < 0)
    {
        Console.WriteLine("Factorial is not defined for negative numbers.");
        return -1; // invalid input case
    }

    if (n == 0 || n == 1)
    {
        return 1;
    }
    return n * factorial(n - 1);
}

// get the user input
Console.Write("Enter a number: ");
int val;

// convert the input into an integer, handle errors if input is invalid
if (!int.TryParse(Console.ReadLine(), out val))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return; // exit the program if input is invalid
}

// get factorial and display result
int result = factorial(val);

// print the result if the input was valid
if (result != -1)
{
    Console.WriteLine("Factorial: {0}", result);
}
