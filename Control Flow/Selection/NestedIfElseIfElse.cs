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
else if (num < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}