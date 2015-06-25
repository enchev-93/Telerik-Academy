//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of {0} is {1}", num, DecimalTooBinaryCalculate(num));
    }

    static string DecimalTooBinaryCalculate(int num)
    {
        int remainder;
        string binary = "";

        while (num != 0)
        {
            remainder = num % 2;
            num /= 2;
            binary = remainder.ToString() + binary;
        }

        return binary;
    }
}
