//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class BitExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Before changes: {0}",
            number);
        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("Enter p:");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter q:");
        int q = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter k:");
        int k = int.Parse(Console.ReadLine());

        if (p + k > 32 || q + k > 32)
        {
            Console.WriteLine("Out of range.");
            Console.WriteLine();
        }
        else if ((p < q) && (p + k > q))
        {
            Console.WriteLine("Overlapping.");
            Console.WriteLine();
        }
        else
        {
            for (int i = p, j = q; i < p + k; i++, j++)
            {
                if ((((1 << i) & number) >> i) != (((1 << j) & number) >> j))
                {
                    number = (uint)(number ^ (1 << i));
                    number = (uint)(number ^ (1 << j));
                }
            }
        }
        
        Console.WriteLine("After changes: {0}",
                number);
        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
