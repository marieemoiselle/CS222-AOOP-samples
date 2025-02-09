using System;

int num;

Console.Write("Enter a number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    if (num < 10)
    {
        Console.WriteLine("Small positive");
    }
    else
    {
        Console.WriteLine("Large positive");
    }
}
else
{
    if (num < 0)
    {
        Console.WriteLine("Negative");
    }
    else
    {
        Console.WriteLine("Zero");
    }
}