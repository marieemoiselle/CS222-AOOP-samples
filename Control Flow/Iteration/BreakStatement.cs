using System;

int number;
while (true)
{
    Console.Write("Enter a number (-1 to exit): ");
    number = int.Parse(Console.ReadLine());

    if (number == -1)
    {
        break;
    }

    Console.WriteLine($"You entered: {number}");
}
Console.WriteLine("Loop exited.");