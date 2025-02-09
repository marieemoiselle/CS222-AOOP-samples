using System;

int grade = 110;

switch (grade)
{
    case 100:
        Console.WriteLine("Excellent!");
        break;
    case >= 90 and <= 99:
        Console.WriteLine("Very Good");
        break;
    case >= 80 and <= 89:
        Console.WriteLine("Meritorious");
        break;
    default:
        Console.WriteLine("Invalid Score");
        break;
}
