using System;

char letter = 'a';

switch (char.ToLower(letter))
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("The letter is a Vowel.");
        break;
    default:
        Console.WriteLine("The letter is a Consonant.");
        break;
}