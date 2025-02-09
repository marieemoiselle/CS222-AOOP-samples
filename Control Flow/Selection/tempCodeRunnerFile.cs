using System;

int a = 10;
int b = 20;
int notZero = 16;
int x = 5;
int y = 11;

bool equal = (a == b);            // Checks if `a` and `b` are equal
bool notZero = (number != 0);    // Checks if `number` is not zero
bool greater = (x > y);         // Checks if `x` is greater than `y`

Console.WriteLine($"Is x greater than y? {greater}");
Console.WriteLine($"Are `a` and `b` equal? {equal}");
Console.WriteLine($"Is the number not zero? {notZero}");