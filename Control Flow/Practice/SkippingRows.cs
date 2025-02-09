using System;

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y: ");
int y = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        if (i == y)
        {
            continue;
        }
        Console.Write("*");
    }
    Console.WriteLine();
}