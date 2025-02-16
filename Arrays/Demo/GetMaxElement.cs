using System;

int[] numbers = { 24, 31, 45, 10, 8 };
int length = numbers.Length;
int maxElement = numbers[0];

for (int i = 1; i < length; i++)
{
    if (numbers[i] > maxElement)
    {
        maxElement = numbers[i]; // Updating the maximum value
    }
}

Console.WriteLine("Maximum value: " + maxElement);