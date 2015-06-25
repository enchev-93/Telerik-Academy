//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and 
//prints all the numbers in the interval [1..n], each on a single line.

//Examples:

//input	output
//3 	1
//      2
//      3
//5 	1
//      2
//      3
//      4
//      5
//1	    1

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter n ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
