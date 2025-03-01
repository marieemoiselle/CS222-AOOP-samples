// Constructor Chaining
public class Student
{
    private string name;
    private int age;
    private string department;

    // Full parameterized constructor
    public Student(string name, int age, string department)
    {
        this.name = name;
        this.age = age;
        this.department = department;
    }

    // Constructor with two parameters, defaults department to "Undeclared"
    public Student(string name, int age) : this(name, age, "Undeclared")
    {
        // Additional initialization if needed
    }

    class Program
    {
        static void Main()
        {
            Student s1 = new Student("Nadine", 21, "Computer Science"); // Uses full constructor
            Student s2 = new Student("Dex", 29); // Uses second constructor, defaults department to "Undeclared"
        }
    }
}