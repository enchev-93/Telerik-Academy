//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
//Examples:

//n	Odd?
//3	true
//2	false
//-2 false
//-1 true
//0	false

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter number ");
        int number = int.Parse(Console.ReadLine());
        bool odd = (number % 2) != 0;

        Console.Clear();
        Console.WriteLine("Number {0} is odd?\n{1}",
            number, odd);
    }
}