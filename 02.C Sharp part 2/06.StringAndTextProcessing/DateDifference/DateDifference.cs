//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        DateTime firstDate;
        DateTime secondDate;

        Console.Write("Enter first date (d.MM.yyyy): ");
        while (!DateTime.TryParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out firstDate))
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter first date (d.MM.yyyy): ");
        }

        Console.Write("Enter second date (d.MM.yyyy): ");
        while (!DateTime.TryParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out secondDate))
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter second date (d.MM.yyyy): ");
        }

        TimeSpan days = secondDate - firstDate;
        Console.WriteLine("Distance: " + Math.Abs(days.Days));
    }
}
