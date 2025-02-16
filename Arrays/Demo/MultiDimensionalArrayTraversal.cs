using System;

int[,] arr = {
			{ 6, 12, 18, 24 },
			{ 8, 16, 24, 32 },
			{ 10, 20, 30, 40 }
		};

int rows = arr.GetLength(0);
int columns = arr.GetLength(1);

// Outer loop is for the number of rows
for (int i = 0; i < rows; i++)
{
    // Inner loop is for the elements per row
    for (int j = 0; j < columns; j++)
    {
        Console.Write(arr[i, j] + " "); // Accessing and printing each element
    }
Console.WriteLine(); // Moving to the next row
}