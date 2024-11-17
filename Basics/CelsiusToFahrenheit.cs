using System;
double cel;
Console.Write("Enter a Celsius value: ");
cel = double.Parse(Console.ReadLine());
double far = (cel * 9/5) + 32;
Console.Write("{0:N2} Celsius is {1:N2} Fahrenheit", cel, far);