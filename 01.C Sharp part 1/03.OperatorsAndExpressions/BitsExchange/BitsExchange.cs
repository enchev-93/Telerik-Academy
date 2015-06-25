//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
//Examples:


using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("Before changes: {0}",
            number);
        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(32, '0'));

        uint mask1, mask2;
        for (int i = 3; i < 6; i++)
        {
            uint temporary1 = (number >> i) & 1;
            uint temporary2 = (number >> i + 21) & 1;
            if (temporary1 != temporary2)
            {
                mask1 = (uint)1 << i + 21;
                mask2 = (uint)1 << i;
                number = number ^ mask1;
                number = number ^ mask2;
            }
        }

        Console.WriteLine("After changes: {0}",
                number);
        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
