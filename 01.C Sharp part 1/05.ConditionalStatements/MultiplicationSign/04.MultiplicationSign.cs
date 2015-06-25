//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product
//of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

//a	    b	    c	    result
//5	    2	    2	    +
//-2	-2	    1	    +
//-2	4	    3	    -
//0	    -2.5	4	    0
//-1	-0.5	-5.1	-

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter number for a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number for b");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number for c");
        double c = double.Parse(Console.ReadLine());

        int signCount = 0;

        if (a == 0 || b == 0 || c ==0)
        {
            Console.WriteLine("The sign is \" 0 \"");
        }
        else
        {
            if (a < 0)
            {
                signCount++;
            }
            if (b < 0)
            {
                signCount++;
            }
            if (c < 0)
            {
                signCount++;
            }
            if (signCount % 2 == 0)
            {
                Console.WriteLine("The sign is \" + \"");
            }
            else Console.WriteLine("The sign is \" - \"");
        }

    }
}
