using System;

public class Program
{
	public static void DisplaySum(int a, int b)
	{
		int sum = a + b;
		Console.WriteLine($"The sum of {a} and {b} is {sum}");
	}

    public static void SayHello(string name)
	{
		Console.WriteLine($"Hello, {name}");
	}

	public static void Main()
	{
		int num1 = 12, num2 = 20;
		DisplaySum(num1, num2);
        SayHello("Marie");
	}
}