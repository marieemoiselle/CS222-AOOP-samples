using System;

// Class containing the function
public class MathOperations {
    // C# convention: PascalCase for function names
    public int GetModulus(int num1, int num2) {
        return num1 % num2; // This function returns a value
        // Formal Parameters
    }

    // A non-returning function
    public void GreetUser() {
        Console.WriteLine("This is your greeting!");
        return; // This keyword is optional for void functions
    }
}

class Program {
    static void Main() {
        MathOperations mathOps = new MathOperations();
        // Function Call
        // Actual Parameters
        int result = mathOps.GetModulus(10, 3);
        Console.WriteLine($"Modulus: {result}");
        mathOps.GreetUser();
    }
}