using System;

int rows;
Console.Write("Enter the number of rows: ");
rows = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < rows; i++){
    int coef = 1;
    for(int j = 0; j <= i; j++){
        Console.Write("{0} ", coef);
        coef = coef*(i-j)/(j+1);
        }
    Console.WriteLine();
        }
