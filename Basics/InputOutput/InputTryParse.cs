using System;

Console.WriteLine("Enter a floating-point number: ");
string input = Console.ReadLine();
    if (double.TryParse(input, out double floatValue))
    {
        Console.WriteLine("You entered: " + floatValue);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid floating-point number.");
    }