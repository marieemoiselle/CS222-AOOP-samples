using System;

string color = "Pink";

switch (color.ToLower())
{
    case "purple":
        Console.WriteLine("The color is Purple.");
        break;
    case "pink":
        Console.WriteLine("The color is Pink.");
        break;
    case "peach":
        Console.WriteLine("The color is Peach.");
        break;
    default:
        Console.WriteLine("Unknown color.");
        break;
}