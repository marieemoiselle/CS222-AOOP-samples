using System;

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];

for (int idx = 0; idx < size; idx++)
{
    Console.Write($"Enter element {idx + 1}: ");
    arr[idx] = Convert.ToInt32(Console.ReadLine());
}

// Print the original array
Console.Write("Original array: [");
for (int idx = 0; idx < size; idx++)
{
    Console.Write(arr[idx]);
    if (idx < size - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");

// Print the reversed array
Console.Write("Reversed array: [");
for (int idx = size - 1; idx >= 0; idx--)
{
    Console.Write(arr[idx]);
    if (idx > 0)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");
