//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
//Examples:

//n	    binary representation	bit #3
//5	    00000000 00000101   	0
//0	    00000000 00000000	    0
//15	00000000 00001111	    1
//5343	00010100 11011111	    1
//62241	11110011 00100001   	0

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        int position = 3;

        Console.WriteLine("Enter number ");
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("The bit at position 3 is: {0}",
          bit);
    }
}
