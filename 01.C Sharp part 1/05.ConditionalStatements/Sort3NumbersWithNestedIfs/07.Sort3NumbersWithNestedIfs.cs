//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

//Examples:

//a	    b	    c	    result
//5	    1	    2	    5 2 1
//-2	-2	    1	    1 -2 -2
//-2	4	    3	    4 3 -2
//0	    -2.5	5	    5 0 -2.5
//-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
//10	20	    30	    30 20 10
//1	    1	    1	    1 1 1

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter c");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("The result is:");
            Console.Write(a);
            if (b >= c)
            {
                Console.WriteLine(" " + b + " " + c);
            }
            else if (c >= b)
            {
                Console.WriteLine(" " + c + " " + b);
            }
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("The result is:");
            Console.Write(b);
            if (a >= c)
            {
                Console.WriteLine(" " + a + " " + c);
            }
            else if (c >= a)
            {
                Console.WriteLine(" " + c + " " + a);
            }
        }
        else if (c >= b && c >= a)
        {
            Console.WriteLine("The result is:");
            Console.Write(c);
            if (b >= a)
            {
                Console.WriteLine(" " + b + " " + a);
            }
            else if (a >= b)
            {
                Console.WriteLine(" " + a + " " + b);
            }
        }
    }
}