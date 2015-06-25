//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class Workdays
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime now = DateTime.Now;

        Console.Write("Enter date till the end of the year, format mm-dd-yyyy: ");
        string input = Console.ReadLine();
        int[] splittedInput = input.Split('-').Select(int.Parse).ToArray();
        DateTime selectedDate = new DateTime(splittedInput[2], splittedInput[1], splittedInput[0]);

        Console.WriteLine("Total workdays from {0:dd/MM/yyyy} to {1:dd/MM/yyyy}: {2}", now, selectedDate, NumberOfWorkdays(now, selectedDate));

    }

    static readonly DateTime[] holidays =
    {
        new DateTime(2015, 1, 1),
        new DateTime(2015, 3, 3),
        new DateTime(2015, 4, 10),
        new DateTime(2015, 4, 13),
        new DateTime(2015, 5, 1),
        new DateTime(2015, 5, 6),
        new DateTime(2015, 5, 24),
        new DateTime(2015, 9, 6),
        new DateTime(2015, 9, 22),
        new DateTime(2015, 12, 24),
        new DateTime(2015, 12, 25)
    };

    static readonly DateTime[] workingWeeks =
    {
        new DateTime(2015, 1, 2),
        new DateTime(2015, 3, 2),
        new DateTime(2015, 9, 21),
        new DateTime(2015, 12, 31)
    };

    static int NumberOfWorkdays(DateTime now, DateTime selectedDate)
    {
        int numberOfWorkdays = 0;

        if (now > selectedDate)
        {
            DateTime temp = now;
            now = selectedDate;
            selectedDate = temp;
        }

        while (now <= selectedDate)
        {
            if (!holidays.Contains(now)
                && !workingWeeks.Contains(now)
                && now.DayOfWeek != DayOfWeek.Saturday
                && now.DayOfWeek != DayOfWeek.Sunday)
            {
                numberOfWorkdays++;
            }
            now = now.AddDays(1);
        }

        return numberOfWorkdays;
    }
}
