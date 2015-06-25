//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year to check if it is leap: ");
        int year = int.Parse(Console.ReadLine());

        bool leapYear = DateTime.IsLeapYear(year);
        Console.WriteLine(leapYear);
    }
}
