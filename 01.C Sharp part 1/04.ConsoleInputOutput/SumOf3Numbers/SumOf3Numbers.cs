//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a 	b	    c	    sum
//3	    4	    11	    18
//-2	0	    3	    1
//5.5	4.5 	20.1	30.1

using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("And now i will sum them :)");

        Console.WriteLine("The sum of the entered numbers is: {0}",
            a + b + c);
    }
}
