//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Collections.Generic;

class DatesFromTextInCanada
{
    static void Main()
    {
        string text = "Some text with dates 15.10.2015, 2.25.2015, 1.1.2015, 10.02.2015, 02.25.2015";
        string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        List<DateTime> dates = new List<DateTime>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][words[i].Length - 1] == '.')
            {
                words[i] = words[i].Substring(0, words[i].Length - 1);
            }

            DateTime date;
            if (DateTime.TryParseExact(words[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                dates.Add(date);
            }
        }

        foreach (var item in dates)
        {
            Console.WriteLine(item.ToString(new CultureInfo("en-CA")));
        }
    }
}
