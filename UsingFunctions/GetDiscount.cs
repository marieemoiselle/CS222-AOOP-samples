using System;

void GetDiscount(double total, out double discount, out double finalp)
{
    double rate;

    if (total > 5000)
    {
        rate = 0.10;
    }
    else
    {
        rate = 0.05;
    }

    discount = total * rate;
    finalp = total - discount;
}

double total, discount, finalp;

Console.Write("Enter the total purchase amount: ");
total = Convert.ToDouble(Console.ReadLine());

GetDiscount(total, out discount, out finalp);

Console.WriteLine($"Initial Purchase Amount: {total:F2}");
Console.WriteLine($"Discount: {discount:F2}");
Console.WriteLine($"Final Price: {finalp:F2}");
