using System;

bool IsPalindromeCheck(string str, int start, int end)
{
    if (start >= end)
    {
        return true;
    }

    if (str[start] != str[end])
    {
        return false;
    }

    return IsPalindromeCheck(str, start + 1, end - 1);
}

bool IsPalindrome(string str)
{
    return IsPalindromeCheck(str, 0, str.Length - 1);
}

Console.Write("Please enter a string: ");
string value = Console.ReadLine();

if (IsPalindrome(value))
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not a Palindrome");
}
