using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> values = new List<int>();

        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Input a number (0 to exit): ");

            string input = Console.ReadLine();
            inputNumber = int.Parse(input);

            if (inputNumber != 0)
            {
                values.Add(inputNumber);
            }
        }

        int totalSum = 0;
        foreach (int value in values)
        {
            totalSum += value;
        }

        Console.WriteLine($"The total sum is: {totalSum}");

        float mean = ((float)totalSum) / values.Count;
        Console.WriteLine($"The mean is: {mean}");

        int highest = values[0];
        foreach (int value in values)
        {
            if (value > highest)
            {
                highest = value;
            }
        }

        Console.WriteLine($"The highest number is: {highest}");
    }
}
