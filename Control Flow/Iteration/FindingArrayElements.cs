using System;

int[] numbers = { 1, 2, 3, 4, 5 };
int searchNumber = 6;
int index = -1;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchNumber)
    {
        index = i;
        break;
    }
}

if (index != -1)
{
    Console.WriteLine($"Element found at index {index}");
}
else
{
    Console.WriteLine($"Element not found. Index: {index}");
}