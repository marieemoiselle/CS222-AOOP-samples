using System;

bool IsPalindrome(int number)
{
    int original = number;
    int reversed = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reversed = reversed * 10 + digit;
        number /= 10;
    }

    return original == reversed;
}

Console.Write("Enter a number: ");
int value = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(value))
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not a Palindrome");
}