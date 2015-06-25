//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number,
//hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        int number = 15;

        Console.WriteLine("{0,15}{1,15}{2,15}{3,15}", "Decimal", "Hexadecimal", "Percent", "Scientific");
        Console.WriteLine("{0,15:D}{1,15:X}{2,15:P}{3,15:E}", number, number ,(double)number / 100 ,number);
    }
}
