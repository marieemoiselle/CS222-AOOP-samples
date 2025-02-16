using System;

class Program
{
	// Method to display a 2D array
	static void DisplayArray(int[,] arr)
	{
		int rows = arr.GetLength(0);
		int cols = arr.GetLength(1);

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				Console.Write("{0,4}", arr[i, j] + " ");
			}
			Console.WriteLine();
		}
	}

	static void Main()
	{
		int[,] matrix = { { 6, 12, 18 }, { 24, 30, 36 }, { 42, 48, 54 } };

		// Passing the 2D array to the method
		DisplayArray(matrix);
	}
}