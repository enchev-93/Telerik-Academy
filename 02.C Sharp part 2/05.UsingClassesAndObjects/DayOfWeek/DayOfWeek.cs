﻿//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;

class DayOfWeek
{
    static void Main()
    {
        var day = DateTime.Now.DayOfWeek;
        Console.WriteLine("Today is: {0}", day);
    }
}