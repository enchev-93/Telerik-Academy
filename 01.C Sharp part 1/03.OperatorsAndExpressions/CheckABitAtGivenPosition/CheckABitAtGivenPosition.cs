//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position 
//p (counting from 0, starting from the right) in given integer number n, has value of 1.
//Examples:

//n	    binary representation of n	    p	bit @ p == 1
//5	    00000000 00000101           	2	    true
//0	    00000000 00000000	            9	    false
//15	00000000 00001111	            1	    true
//5343	00010100 11011111	            7	    true
//62241	11110011 00100001	            11  	false

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter number ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of {0} is {1}.",
            number, Convert.ToString(number, 2).PadLeft(16, '0'));

        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        bool itIsOne = true;
        bool itIsZero = false;
        if (bit == 1)
        {
            Console.WriteLine("Is the bit at position {0} == 1? \n{1}",
                position, itIsOne);
        }
        else
        {
            Console.WriteLine("Is the bit at position {0} == 1? \n{1}",
                position, itIsZero);
        }
    }
}
