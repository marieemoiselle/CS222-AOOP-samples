using System;

class Person
{
	// Fields
	private string name;
	private int age;

	// Constructor
	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

	// Method to display person's information
	public void DisplayInfo()
	{
		Console.WriteLine($"Name: {name}, Age: {age}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		// Create instances of Person class
		Person person1 = new Person("Samantha Maureen Vera", 28);
		Person person2 = new Person("Clyden Jaile Ramirez", 30);

		// Call the DisplayInfo method for each person
		person1.DisplayInfo();
		person2.DisplayInfo();
	}
}