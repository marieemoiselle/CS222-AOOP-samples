using System;
int up_bound;
int num = 1;
int sum = 0;
Console.Write("Enter a number: ");
up_bound = Convert.ToInt32(Console.ReadLine());

while(num <= up_bound){
    sum+=num;
    num++;
}

Console.Write("Sum from 1 to {0} is: {1}", up_bound, sum );