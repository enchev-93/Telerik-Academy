//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        Console.WriteLine("Decimal representation of {0} is: {1}", hexadecimal,HexadecimalToDecimalCalculate(hexadecimal));
    }

    static int HexadecimalToDecimalCalculate(string hexadecimal)
    {
        int result = 0;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            if (char.IsDigit(hexadecimal[i]))
            {
                result += (int)((hexadecimal[i] - '0') * Math.Pow(16, hexadecimal.Length - i - 1));
            }
            else
            {
                switch (hexadecimal[i])
                {
                    case 'A': 
                        result += (int)(10 * Math.Pow(16, hexadecimal.Length - i - 1));
                        break;
                    case 'B': 
                        result += (int)(11 * Math.Pow(16, hexadecimal.Length - i - 1)); 
                        break;
                    case 'C':
                        result += (int)(12 * Math.Pow(16, hexadecimal.Length - i - 1)); 
                        break;
                    case 'D':
                        result += (int)(13 * Math.Pow(16, hexadecimal.Length - i - 1)); 
                        break;
                    case 'E': 
                        result += (int)(14 * Math.Pow(16, hexadecimal.Length - i - 1));
                        break;
                    case 'F': 
                        result += (int)(15 * Math.Pow(16, hexadecimal.Length - i - 1)); 
                        break;
                }
            }
        }

        return result;
    }
}
