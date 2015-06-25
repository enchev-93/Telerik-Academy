//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        decimal reversed = Reverser(number);
        Console.WriteLine("Reversed: {0}", reversed);

    }

    static decimal Reverser(decimal number)
    {
        return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}