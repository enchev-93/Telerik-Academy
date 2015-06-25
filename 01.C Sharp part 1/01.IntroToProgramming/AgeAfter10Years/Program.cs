//Problem 15.* Age after 10 Years
//
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime birthDay = new DateTime(1993, 01, 10);
        DateTime todaysDate = DateTime.Now;
        var MyAge = todaysDate.Year - birthDay.Year;
        Console.WriteLine("My age is: " + MyAge);
        var MyFutureAge = MyAge + 10;
        Console.WriteLine("My age in 10 years will be:" + MyFutureAge);
    }
}
