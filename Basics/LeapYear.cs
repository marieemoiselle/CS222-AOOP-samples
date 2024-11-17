using System;

Console.Write("Enter a year: ");
if (int.TryParse(Console.ReadLine(), out int year))
{
    if (year % 400 == 0)
    {
        Console.WriteLine("Leap Year");
    }
    else if (year % 100 == 0)
    {
        Console.WriteLine("Not a Leap Year");
    }
    else if (year % 4 == 0)
    {
        Console.WriteLine("Leap Year");
    }
    else
    {
        Console.WriteLine("Not a Leap Year");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid year.");
}
