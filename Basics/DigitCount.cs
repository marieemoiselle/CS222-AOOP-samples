using System;

int num;
int digits = 0;

Console.Write("Please enter a number: ");
num = Convert.ToInt32(Console.ReadLine());

while(num > 0){
    digits++;
    num = num/10;
    }

Console.Write("Number of digits in the given number is: {0}", digits);