//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	    hexadecimal
//254	        FE
//6883	        1AE3
//338583669684	4ED528CBB4

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decNumber = long.Parse(Console.ReadLine());

        string hexaNumber = "";

        while (decNumber > 0)
        {
            long n = decNumber % 16;
            decNumber /= 16;
            switch (n)
            {
                case 10: hexaNumber = "A" + hexaNumber;
                    break;
                case 11: hexaNumber = "B" + hexaNumber;
                    break;
                case 12: hexaNumber = "C" + hexaNumber;
                    break;
                case 13: hexaNumber = "D" + hexaNumber;
                    break;
                case 14: hexaNumber = "E" + hexaNumber;
                    break;
                case 15: hexaNumber = "F" + hexaNumber;
                    break;
                default: hexaNumber = n + hexaNumber;
                    break;
            }
        }
        Console.WriteLine(hexaNumber);
    }
}
