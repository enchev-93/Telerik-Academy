using System;
using System.Numerics;

class Problem3
{
    static void Main()
    {
        BigInteger product = 1;
        BigInteger even = 0;
        BigInteger sum = 1;
        BigInteger sumAfterTen = 1;

        for (int i = 2; i <= 11; i++)
        {
            string numbers = Console.ReadLine();

            if (numbers == "0")
            {
                numbers = "1";
            }
            if (even % 2 == 0)
            {
                foreach (char number in numbers)
                {
                    if (char.IsDigit(number) && number != 0)
                    {
                        product *= number - '0';
                    }
                }
                sum *= product;
                product = 1;
            }
            even++;

            if (i > 11)
            {
                break;
            }
        }

        for (int i = 11; i <= 10000; i++)
        {
            string numbers = Console.ReadLine();

            if (numbers == "0")
            {
                numbers = "1";
            }

            if (numbers == "END")
            {
                break;
            }
            if (even % 2 == 0)
            {
                foreach (char number in numbers)
                {
                    if (char.IsDigit(number) && number != 0)
                    {
                        product *= number - '0';
                    }
                }
                sumAfterTen *= product;
                product = 1;
            }
            even++;
        }
        Console.WriteLine(sum);
        Console.WriteLine(sumAfterTen);
    }
}
