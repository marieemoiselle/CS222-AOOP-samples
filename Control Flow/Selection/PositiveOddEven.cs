using System;

int num = 10;

if (num > 0)
{
    if (num % 2 == 0)
    {
        Console.WriteLine("The number is positive and even.");
    }
    else
    {
        Console.WriteLine("The number is positive and odd.");
    }
}
else
{
    Console.WriteLine("The number is non-positive.");
}