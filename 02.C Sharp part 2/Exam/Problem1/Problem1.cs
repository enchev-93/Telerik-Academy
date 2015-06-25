using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Problem1
{
    static ulong ResultConverterTo10th(string word)
    {
        ulong resultTo10th = 0;
        for (int i = 0; i < word.Length; i++)
        {
            switch (word[i])
            {
                case 'a': resultTo10th += (0 * PowerOf21(word.Length - i - 1)); break;
                case 'b': resultTo10th += (1 * PowerOf21(word.Length - i - 1)); break;
                case 'c': resultTo10th += (2 * PowerOf21(word.Length - i - 1)); break;
                case 'd': resultTo10th += (3 * PowerOf21(word.Length - i - 1)); break;
                case 'e': resultTo10th += (4 * PowerOf21(word.Length - i - 1)); break;
                case 'f': resultTo10th += (5 * PowerOf21(word.Length - i - 1)); break;
                case 'g': resultTo10th += (6 * PowerOf21(word.Length - i - 1)); break;
                case 'h': resultTo10th += (7 * PowerOf21(word.Length - i - 1)); break;
                case 'i': resultTo10th += (8 * PowerOf21(word.Length - i - 1)); break;
                case 'j': resultTo10th += (9 * PowerOf21(word.Length - i - 1)); break;
                case 'k': resultTo10th += (10 * PowerOf21(word.Length - i - 1)); break;
                case 'l': resultTo10th += (11 * PowerOf21(word.Length - i - 1)); break;
                case 'm': resultTo10th += (12 * PowerOf21(word.Length - i - 1)); break;
                case 'n': resultTo10th += (13 * PowerOf21(word.Length - i - 1)); break;
                case 'o': resultTo10th += (14 * PowerOf21(word.Length - i - 1)); break;
                case 'p': resultTo10th += (15 * PowerOf21(word.Length - i - 1)); break;
                case 'q': resultTo10th += (16 * PowerOf21(word.Length - i - 1)); break;
                case 'r': resultTo10th += (17 * PowerOf21(word.Length - i - 1)); break;
                case 's': resultTo10th += (18 * PowerOf21(word.Length - i - 1)); break;
                case 't': resultTo10th += (19 * PowerOf21(word.Length - i - 1)); break;
                case 'u': resultTo10th += (20 * PowerOf21(word.Length - i - 1)); break;
            }
        }
        return resultTo10th;
    }

    static string ResultConvertedTo26th(ulong resultTo10th)
    {
        ulong remainder;
        string resultTo26th = string.Empty;

        while (resultTo10th != 0)
        {
            remainder = resultTo10th % 26;
            resultTo10th /= 26;

            switch (remainder)
            {
                case 0: resultTo26th += 'a'; break;
                case 1: resultTo26th += 'b'; break;
                case 2: resultTo26th += 'c'; break;
                case 3: resultTo26th += 'd'; break;
                case 4: resultTo26th += 'e'; break;
                case 5: resultTo26th += 'f'; break;
                case 6: resultTo26th += 'g'; break;
                case 7: resultTo26th += 'h'; break;
                case 8: resultTo26th += 'i'; break;
                case 9: resultTo26th += 'j'; break;
                case 10: resultTo26th += 'k'; break;
                case 11: resultTo26th += 'l'; break;
                case 12: resultTo26th += 'm'; break;
                case 13: resultTo26th += 'n'; break;
                case 14: resultTo26th += 'o'; break;
                case 15: resultTo26th += 'p'; break;
                case 16: resultTo26th += 'q'; break;
                case 17: resultTo26th += 'r'; break;
                case 18: resultTo26th += 's'; break;
                case 19: resultTo26th += 't'; break;
                case 20: resultTo26th += 'u'; break;
                case 21: resultTo26th += 'v'; break;
                case 22: resultTo26th += 'w'; break;
                case 23: resultTo26th += 'x'; break;
                case 24: resultTo26th += 'y'; break;
                case 25: resultTo26th += 'z'; break;
            }
        }

        return new string(resultTo26th.ToCharArray().Reverse().ToArray());
    }

    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        string[] test = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            test[i] = ResultConvertedTo26th(ResultConverterTo10th(words[i]));

        }
        Console.WriteLine(string.Join(" ", test));
    }

    static ulong PowerOf21(int power)
    {
        ulong result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= 21;
        }

        return result;
    }
}