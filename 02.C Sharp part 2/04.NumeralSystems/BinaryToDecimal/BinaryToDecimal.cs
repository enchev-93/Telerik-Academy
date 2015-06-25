//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        Console.WriteLine("Decimal representation of {0} is {1}", binary, BinaryToDecimalCalculate(binary));
    }
    
    static int BinaryToDecimalCalculate(string binary)
    {
        int number = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            number += (int)((binary[i] - '0') * Math.Pow(2, binary.Length - i - 1));
        }

        return number;
    }
}
