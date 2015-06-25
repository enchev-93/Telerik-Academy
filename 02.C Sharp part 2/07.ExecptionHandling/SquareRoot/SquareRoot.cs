﻿//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter integer number: ");
            uint number = uint.Parse(Console.ReadLine());
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is: {1}", number, squareRoot);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}