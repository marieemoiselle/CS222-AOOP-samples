using System;

class Program
{
    static float Average(int sum, int count)
    {
        if (count == 0)
            return 0;

        return (float)sum / count;
    }

    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;

        Console.WriteLine("Enter numbers: ");

        while (true)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
                break;

            sum += input;
            count++;
        }

        float avg = Average(sum, count);
        Console.WriteLine($"Average: {avg:F2}");
    }
}