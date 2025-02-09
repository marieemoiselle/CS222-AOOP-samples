using System;

int total = 10;

Console.Write("Enter an integer: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("The number is even.");
        total += (int) Math.Pow(number, 2);
    }
    else
    {
        Console.WriteLine("The number is odd.");
        total += (int) Math.Pow(number, 3);
    }
    Console.Write(total);
}
else if (number < 0)
{
    Console.Write("Enter another integer: ");
    int exponent = Convert.ToInt32(Console.ReadLine());
    
    total += (int) Math.Pow(number, exponent);
    Console.Write(total);
}
else
{
    Console.Write("Nothing happened.");
}
