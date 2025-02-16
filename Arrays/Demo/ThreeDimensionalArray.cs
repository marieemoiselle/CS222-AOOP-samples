using System;

int[,,] values = {
    {
        { 10, 20, 30, 40 },
        { 5, 10, 15, 20 },
        { 15, 30, 45, 60 }
    },
    {
        { 7, 14, 21, 28 },
        { 4, 8, 12, 16 },
        { 6, 12, 18, 24 }
    }
};

int depth = values.GetLength(0);
int rows = values.GetLength(1);
int columns = values.GetLength(2);

for (int i = 0; i < depth; i++)
{
    Console.WriteLine("Depth " + i + ":");
    for (int j = 0; j < rows; j++)
    {
        for (int k = 0; k < columns; k++)
        {
            Console.Write("{0,4}", values[i, j, k] + " "); // Accessing and printing each element
            // Right-aligned, 4-character width
        }
    Console.WriteLine(); // Move to the next row
    }
Console.WriteLine(); // Separate each depth with a new line
}