//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: 
//day.month.year hour:minute:second and prints the date and time after 
//6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

class DateInBulgaria
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        DateTime bulgarianDateTime;
        Console.Write("Enter date in format (d.M.yyyy HH:mm:ss): ");
        while (!DateTime.TryParseExact(Console.ReadLine(), "d.M.yyyy H:m:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out bulgarianDateTime))
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter date in format (d.M.yyyy HH:mm:ss): ");
        }

        CultureInfo bg = new CultureInfo("bg-BG");
        string day = bg.DateTimeFormat.GetDayName(bulgarianDateTime.DayOfWeek);
        Console.WriteLine("{0:d.M.yyyy HH:mm:ss} {1}", bulgarianDateTime.AddHours(6).AddMinutes(30), day);
    }
}
