using System;
using System.Numerics;

class StrangeLandNumbers
{
    static BigInteger Power(BigInteger number, BigInteger power)
    {
        BigInteger result = 1;

        for (BigInteger i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }

    static void Main()
    {
        string strangeNumber = Console.ReadLine()
            .Replace("f", "0")
            .Replace("bIN", "1")
            .Replace("oBJEC", "2")
            .Replace("mNTRAVL", "3")
            .Replace("lPVKNQ", "4")
            .Replace("pNWE", "5")
            .Replace("hT", "6");

        BigInteger power = 0;
        BigInteger result = 0;
        for (int i = strangeNumber.Length - 1; i >= 0; i--)
        {
            BigInteger currentNumber = strangeNumber[i] - '0';
            result += currentNumber * Power(7, power);
            power++;
        }

        Console.WriteLine(result);
    }
}
