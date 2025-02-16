using System;

public class Program
{
    public static int ComputeSum(int a, int b)
	{
		return a + b;
	}

	public static int FindSquare(int num)
	{
		return num * num;
	}

	public static void Main()
	{
		int num1 = 27, num2 = 18;
        int sum = ComputeSum(num1, num2);
		int squared = FindSquare(num1);
        Console.WriteLine($"Sum of {num1} and {num2}: {sum}");
        Console.WriteLine($"Square of {num1}: {squared}");
	}
}