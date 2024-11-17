using System;
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c){
    Console.Write("Max: {0}", a);
}

else if(b > a && b > c){
    Console.Write("Max: {0}", b);
}

else if(c > a && c > b){
    Console.Write("Max: {0}", c);
}