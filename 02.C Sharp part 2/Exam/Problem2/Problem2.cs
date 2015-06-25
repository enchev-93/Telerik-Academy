using System;
using System.Collections.Generic;
using System.Numerics;

class Problem1
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        bool[] test = new bool[(int)n];
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            BigInteger[] numbers = StringToNumbersConverter(input);
            BigInteger[] sequence = new BigInteger[numbers.Length - 1];

            for (int j = 1; j < numbers.Length; j++)
            {
                sequence[j - 1] = AbsoluteDiffrence(numbers[j], numbers[j - 1]);// Math.Abs(numbers[j] - numbers[j - 1]);
            }

            for (int k = 1; k < sequence.Length; k++)
            {
                if (sequence[k - 1] <= sequence[k]
                    && (sequence[k] - sequence[k - 1] == 1
                    || sequence[k] - sequence[k - 1] == 0))
                {
                    test[i] = true;
                }
                else
                {
                    test[i] = false;
                    break;
                }
            }
        }
        Console.WriteLine(string.Join("\n", test));
    }

    static BigInteger[] StringToNumbersConverter(string input)
    {
        string[] numbersString = input.Split(' ');

        BigInteger[] numbers = new BigInteger[numbersString.Length];
        for (int i = 0; i < numbersString.Length; i++)
        {
            numbers[i] = BigInteger.Parse(numbersString[i]);
        }

        return numbers;
    }

    static BigInteger AbsoluteDiffrence(BigInteger a, BigInteger b)
    {
        BigInteger result = 0;

        if (a > b)
        {
            result = a - b;
        }
        else
        {
            result = b - a;
        }

        return result;
    }
}