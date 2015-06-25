﻿//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(GetMax(a, b), c));
    }

    static int GetMax(int a, int b)
    {
        int biggest = 0;
        if (a > b)
        {
            biggest = a;
        }
        else if (b > a)
        {
            biggest = b;
        }
        return biggest;
    }
}