using System;

void GetMultiples(int x)
{
    int ctr = 1;
    while (ctr <= 10)
    {
        int product = x * ctr;
        Console.WriteLine($"{x} x {ctr} = {product}");
        ctr++;
    }
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

GetMultiples(number);
