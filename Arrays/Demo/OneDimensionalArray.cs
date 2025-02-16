using System;

int[] values = new int[5];  // Declaration of an integer array

values[0] = 9;  // Assigning a value to the first element
values[1] = 18;  // Assigning a value to the second element

for (int i = 0; i < values.Length; i++)
{
	Console.Write($"{values[i]}  ");  // Printing each element of the array
}

Console.WriteLine();

int sum = values[0] + values[1];  // Accessing and performing operations on array elements
Console.WriteLine($"Sum: {sum}");  // Output the sum of the first and second elements