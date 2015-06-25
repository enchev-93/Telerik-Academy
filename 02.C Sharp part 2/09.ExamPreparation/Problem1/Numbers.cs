using System;
using System.Collections.Generic;
using System.Linq;

class Numbers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');

        Console.WriteLine(Convert10thTo19th(Convert19thTo10th(numbers)) + " = " + Convert19thTo10th(numbers));
    }

    static long Convert19thTo10th(string[] numbers)
    {
        long resultIn10th = 0;
        foreach (var item in numbers)
        {
            for (int i = 0; i < item.Length; i++)
            {
                switch (item[i])
                {
                    case 'a': resultIn10th += (long)(0 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'b': resultIn10th += (long)(1 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'c': resultIn10th += (long)(2 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'd': resultIn10th += (long)(3 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'e': resultIn10th += (long)(4 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'f': resultIn10th += (long)(5 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'g': resultIn10th += (long)(6 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'h': resultIn10th += (long)(7 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'i': resultIn10th += (long)(8 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'j': resultIn10th += (long)(9 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'k': resultIn10th += (long)(10 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'l': resultIn10th += (long)(11 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'm': resultIn10th += (long)(12 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'n': resultIn10th += (long)(13 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'o': resultIn10th += (long)(14 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'p': resultIn10th += (long)(15 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'q': resultIn10th += (long)(16 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 'r': resultIn10th += (long)(17 * PowerOfNineteen(item.Length - i - 1)); break;
                    case 's': resultIn10th += (long)(18 * PowerOfNineteen(item.Length - i - 1)); break;
                }
            }
        }

        return resultIn10th;
    }

    static string Convert10thTo19th(long resultIn10th)
    {
        string result = string.Empty;
        long remainder;

        while (resultIn10th != 0)
        {
            remainder = resultIn10th % 19;
            resultIn10th /= 19;

            switch (remainder)
            {
                case 0: result += 'a'; break;
                case 1: result += 'b'; break;
                case 2: result += 'c'; break;
                case 3: result += 'd'; break;
                case 4: result += 'e'; break;
                case 5: result += 'f'; break;
                case 6: result += 'g'; break;
                case 7: result += 'h'; break;
                case 8: result += 'i'; break;
                case 9: result += 'j'; break;
                case 10: result += 'k'; break;
                case 11: result += 'l'; break;
                case 12: result += 'm'; break;
                case 13: result += 'n'; break;
                case 14: result += 'o'; break;
                case 15: result += 'p'; break;
                case 16: result += 'q'; break;
                case 17: result += 'r'; break;
                case 18: result += 's';break;
            }
        }

        return new string(result.ToCharArray().Reverse().ToArray());
    }

    static long PowerOfNineteen(long power)
    {
        long result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= 19;
        }

        return result;
    }
}
