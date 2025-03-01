using System;

public class Program
{
    public static void GreetStudent(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static void Main()
    {   
        string name = "Clyden";
        GreetStudent(name);
    }
}



