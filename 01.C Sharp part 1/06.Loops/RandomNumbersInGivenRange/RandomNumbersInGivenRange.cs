//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) 
//and prints n random numbers in the range [min...max].
//Examples:

//n	    min	max	random numbers
//5	    0	1	1 0 0 1 1
//10	10	15	12 14 12 15 10 12 14 13 13 11

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter n value: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter min value: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Enter max value: ");
        int max = int.Parse(Console.ReadLine());

        if (min != max && min < max)
        {
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", r.Next(min, max + 1));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The min value must be diffrent from the max value\nand can not be bigger than the max value.");
        }
    }
}
