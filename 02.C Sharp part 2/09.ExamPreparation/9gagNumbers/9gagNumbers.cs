using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class _9gagNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        string partialInput = string.Empty;
        string nineSystemNumber = "";

        for (int i = 0; i < input.Length; i++)
        {
            partialInput += input[i];

            string currentDigit = ConvertGagStringToNumber(partialInput);

            if (currentDigit != "NO")
            {
                nineSystemNumber += currentDigit;
                partialInput = "";
            }
        }

        BigInteger result = 0;

        for (int i = 0; i < nineSystemNumber.Length; i++)
        {
            BigInteger digit = BigInteger.Parse(nineSystemNumber[i].ToString());

            result += digit * PowerOfNine(nineSystemNumber.Length - i - 1);
        }

        Console.WriteLine(result);
    }

    static BigInteger PowerOfNine(int power)
    {
        BigInteger result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }

        return result;
    }

    static string ConvertGagStringToNumber(string digit)
    {
        string result = "NO";

        switch (digit)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
        }

        return result;
    }
}
