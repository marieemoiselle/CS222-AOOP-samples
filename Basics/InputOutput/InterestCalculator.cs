using System;

Console.Write("Enter principal amount: ");
double principal = double.Parse(Console.ReadLine());
Console.Write("Enter rate of interest: ");
double rate = double.Parse(Console.ReadLine());
Console.Write("Enter time in years: ");
double time = double.Parse(Console.ReadLine());

double simpleInterest = (principal * rate * time) / 100;
Console.WriteLine($"Simple Interest: {simpleInterest}");