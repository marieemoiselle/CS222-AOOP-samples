using System;

int GetLongestWord(string sentence)
{
    var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int max = 0;

    foreach (var word in words)
    {
        int length = word.Length;
        if (length > max)
        {
            max = length;
        }
    }

    return max;
}

Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();

int longest = GetLongestWord(sentence);
Console.WriteLine($"Length of the longest word: {longest}");
