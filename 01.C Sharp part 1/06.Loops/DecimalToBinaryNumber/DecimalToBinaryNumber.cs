//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	    binary
//0	            0
//3	            11
//43691	        1010101010101011
//236476736	    1110000110000101100101000000

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decNumber = long.Parse(Console.ReadLine());

        string binary = "";

        if (decNumber == 0)
        {
            Console.WriteLine("The binary result is: 0");
        }
        else
        {
            while (decNumber >= 1)
            {
                binary = (decNumber % 2) + binary;
                decNumber = decNumber / 2;
            }
            Console.WriteLine("The binary result is: {1}",
                decNumber, binary);
        }
    }
}
