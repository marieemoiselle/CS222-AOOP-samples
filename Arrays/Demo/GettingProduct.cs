using System;

int[] values = { 9, 18, 27, 36, 45 };
int length = values.Length;
int product = 1;

for (int idx = 0; idx < length; idx++)
{
    product *= values[idx]; // Multiplying each element to the product
}

Console.WriteLine($"Product of elements: {product}");