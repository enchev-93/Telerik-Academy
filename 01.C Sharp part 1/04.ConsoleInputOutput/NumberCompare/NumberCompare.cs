﻿//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:

//a	    b	    greater
//5	    6	    6
//10	5	    10
//0 	0	    0
//-5	-2	    -2
//1.5	1.6 	1.6

using System;

class NumberCompare
{
    static void Main()
    {
        Console.WriteLine("Enter number for a ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number for b");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is {0}",
            Math.Max(a, b));
    }
}
