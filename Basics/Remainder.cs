using System;
int num1, num2;

Console.Write("Enter first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

int rem = num1%num2;

Console.Write("Remainder of {0}/{1} is: {2}", num1, num2, rem);
