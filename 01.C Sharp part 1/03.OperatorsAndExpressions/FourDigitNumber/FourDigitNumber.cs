//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

//Examples:

//n	    sum of digits	 reversed	last digit in front	    second and third digits exchanged
//2011	    4	         1102	         1201	                    2101
//3333	    12	         3333	         3333	                    3333
//9876	    30	         6789	         6987	                    9786

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 9999)
        {
            Console.WriteLine("Enter four-digit number!");
        }
        else if (number < 1000)
        {
            Console.WriteLine("Enter four-digit number!");
        }
        else
        {
            int a = (number / 1000) % 10;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            int sumOfDigits = a + b + c + d;

            Console.Clear();
            Console.WriteLine("The sum of {0} is: {1}",
                number ,sumOfDigits);
            Console.WriteLine("{0} in form \"dcba\" is: {1}{2}{3}{4}",
                number, d, c, b, a);
            Console.WriteLine("{0} if form \"dabc\" is: {1}{2}{3}{4}",
                number, d, a, b, c);
            Console.WriteLine("{0} in form \"acbd\" is: {1}{2}{3}{4}",
                number, a, c, b, d);
        }
    }
}
