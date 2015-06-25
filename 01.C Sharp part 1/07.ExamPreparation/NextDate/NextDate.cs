using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int nextDay = 1;

        


        if (day >= 1 && day <= 31)
        {
            nextDay += day;
        }
        if (year == 2000 || year == 2004 || year == 2008 || year == 2012)
        {
            if (month == 2 && nextDay == 30)
            {
                nextDay = 1;
                month++;
            }
        }

        if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && nextDay == 32)
        {
            nextDay = 1;
            month++;
        }
        if ((month == 4 || month == 6 || month == 9 || month == 11) && nextDay == 31)
        {
            nextDay = 1;
            month++;
        }
        if (month == 2 && nextDay == 29)
        {
            nextDay = 1;
            month++;
        }
        if (day == 31 && month == 13)
        {
            nextDay = 1;
            month = 1;
            year++;
        }


        Console.WriteLine("{0}.{1}.{2}", nextDay, month, year);
    }
}
