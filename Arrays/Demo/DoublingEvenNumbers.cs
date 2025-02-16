using System;
		
int[] values = { 9, 18, 27, 36, 45 };
int length = values.Length;

for (int idx = 0; idx < length; idx++)
{
	if (values[idx] % 2 == 0)
	{
		values[idx] *= 2; // Doubling the even elements
	}
}

Console.Write("New array: ");
foreach (int element in values)
{
	Console.Write(element + " ");
}
Console.WriteLine(); // Move to the next line after printing the array.