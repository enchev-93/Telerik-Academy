//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Linq;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Hexadecimal representation of {0} is {1}", num, DecimalToHexadecimalCalculate(num));
    }

    static string DecimalToHexadecimalCalculate(int num)
    {
        string hexadecimal = "";
        int remainder;

        while (num != 0)
        {
            remainder = num % 16;
            num /= 16;

            if (remainder < 10)
            {
                hexadecimal += remainder.ToString();
            }
            else
            {
                switch (remainder)
                {
                    case 10: hexadecimal += "A"; break;
                    case 11: hexadecimal += "B"; break;
                    case 12: hexadecimal += "C"; break;
                    case 13: hexadecimal += "D"; break;
                    case 14: hexadecimal += "E"; break;
                    case 15: hexadecimal += "F"; break;
                }
            }
        }

        return new string(hexadecimal.ToCharArray().Reverse().ToArray());
    }
}
