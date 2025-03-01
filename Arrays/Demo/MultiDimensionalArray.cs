using System;

int[,] matrix = { { 9, 18, 27, 36 }, { 7, 14, 21, 28 }, { 8, 16, 24, 32 } };
//int [][3]
// type [row, column]  
// Declaration and initialization of a two-dimensional array

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");  
        // Printing each element of the array
    }
Console.WriteLine();  
// Moving to the next row
}

Console.WriteLine($"Rows: {matrix.GetLength(0)}"); // 3 rows
Console.WriteLine($"Columns: {matrix.GetLength(1)}"); // 4 columns