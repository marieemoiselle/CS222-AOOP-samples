using System;

// C# Naming Convention - use Pascal Case in naming functions
// function declaration
int GetModulus(int num1, int num2) {
    return num1 % num2;
}

// Calling the Function
int result = GetModulus(10, 3);
Console.WriteLine($"Modulus: {result}");