using System;
int num1, num2, sum, diff, prod, quot;

Console.Write("Enter first integer: ");
num1 = Convert.ToInt32(Console.ReadLine());
        
Console.Write("Enter second integer: ");
num2 = Convert.ToInt32(Console.ReadLine());
sum = num1 + num2;
diff = num1 - num2;
prod = num1 * num2;
quot = num1/num2;

Console.WriteLine("Sum: {0}", sum);
Console.WriteLine("Difference: {0}", diff);
Console.WriteLine("Product: {0}", prod);
Console.WriteLine("Quotient: {0}", quot);