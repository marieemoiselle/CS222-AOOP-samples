using System;

class Program
{
	static int[] MakeArray(int size)
	{
		int[] sampleArray = new int[size];
		for (int i = 0; i < size; i++)
		{
			sampleArray[i] = i * 5;
		}
		return sampleArray;
	}

	static void Main()
	{
		int size = 5;

		// Calling the method and receiving the new array
		int[] newArr = MakeArray(size);

		// Printing the elements of the returned array
		Console.Write("New Array: ");
		PrintArray(newArr);
	}

	static void PrintArray(int[] sampleArray)
	{
		foreach (int element in sampleArray)
		{
			Console.Write(element + " ");
		}
	}
}

// Output: 0 5 10 15 20