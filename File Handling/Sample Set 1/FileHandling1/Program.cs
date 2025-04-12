using System;
using System.IO;

class Program
{
	static void Main()
	{
		string filePath = "example.txt";
		
		try
		{   
            // Create a file named example.txt and write to it.
			using (StreamWriter writer = File.CreateText(filePath))
			{
				writer.WriteLine("This is a content written to the file.");
                writer.WriteLine("You created a file!");
			}
			
			Console.WriteLine("File created successfully.");

            // Let's read from the file:
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("\n=== FILE CONTENTS ===");
            Console.WriteLine(fileContents);
		}
		catch (Exception ex)
		{
			Console.WriteLine("ERROR: " + ex.Message);
		}
	}
}