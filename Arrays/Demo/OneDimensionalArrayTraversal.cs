using System;

string[] pokemons = {"Bulbasaur", "Charizard", "Jigglypuff", "Swablu", "Pikachu"};
//string.Join() automatically handles the commas between elements
Console.WriteLine(string.Join(", ", pokemons));
// Bulbasaur, Charizard, Jigglypuff, Swablu, Pikachu

// using foreach
int[] values = {7, 14, 21, 28, 35};
foreach (int value in values) 
{
    Console.Write($"{value} ");
}
// Output: 7 12 21 28 35

Console.WriteLine();

// using for loop
double[] numbers = {3.45, 6.88, 3.22, 1.92, 1.53};
int length = numbers.Length;

for(int idx = 0; idx < length; idx++)
{
    Console.Write($"{numbers[idx]} ");
}

// Output: 3.45 6.88 3.22 1.92 1.53