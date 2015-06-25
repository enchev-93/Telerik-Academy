//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges 
//their values if the first one is greater than the second one. As a result print 
//the values a and b, separated by a space.
//Examples:

//a	    b	    result
//5	    2	    2 5
//3	    4	    3 4
//5.5	4.5 	4.5 5.5

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter number for a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number for b:");
        double b = double.Parse(Console.ReadLine());

        double lesserNumber = a;

        if (lesserNumber < b)
        {
            Console.WriteLine("{0} {1}",
            lesserNumber, b);
        }
        else
        {
            Console.WriteLine("{0} {1}",
                b, lesserNumber);
        }
    }
}
