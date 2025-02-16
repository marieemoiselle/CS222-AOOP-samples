using System;

double GetArrayMean(int[] arr, int size)
{
    int sum = 0;
    for (int idx = 0; idx < size; idx++)
    {
        sum += arr[idx];
    }

    return (double)sum / size;
}

Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
for (int idx = 0; idx < n; idx++)
{
    Console.Write("Enter number: ");
    arr[idx] = Convert.ToInt32(Console.ReadLine());
}

double mean = GetArrayMean(arr, n);
Console.WriteLine($"Mean of array is {mean:F2}");
