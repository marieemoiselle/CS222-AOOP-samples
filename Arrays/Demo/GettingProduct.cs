using System;

int[] values = { 9, 18, 27, 36, 45 };
int length = values.Length;
int product = 0;

for (int idx = 0; idx < length; idx++)
{
    product += values[idx]; // Adding each element to the sum
}

Console.WriteLine($"Product of elements: {product}");