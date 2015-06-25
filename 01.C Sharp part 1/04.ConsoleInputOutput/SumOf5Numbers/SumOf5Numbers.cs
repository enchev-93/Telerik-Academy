//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	            sum
//1 2 3 4 5	            15
//10 10 10 10 10	    50
//1.5 3.14 8.2 -1 0	    11.84

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers, separated by spaces \n");
        string[] parts = Console.ReadLine().Split();
        double a = double.Parse(parts[0]);
        double b = double.Parse(parts[1]);
        double c = double.Parse(parts[2]);
        double d = double.Parse(parts[3]);
        double e = double.Parse(parts[4]);

        double sum = a + b + c + d + e;
        Console.WriteLine("The sum of the numbers is: {0}",
            sum);

    }
}
