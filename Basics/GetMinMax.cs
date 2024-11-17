using System;

int num;
int max = 0, min = 0;
bool firstInput = true;

Console.Write("Enter a number: ");
num = Convert.ToInt32(Console.ReadLine());

while (num != 0)
{
    if (firstInput)
    {
        max = num;
        min = num;
        firstInput = false;
    }
    else
    {
        if (num > max)
        {
            max = num;
        }
        if (num < min)
        {
            min = num;
        }
    }

    Console.Write("Enter a number: ");
    num = Convert.ToInt32(Console.ReadLine());
}

if (firstInput)
{
    Console.WriteLine("No inputs");
}
else
{
    Console.WriteLine($"Maximum value: {max}");
    Console.WriteLine($"Minimum value: {min}");
}
