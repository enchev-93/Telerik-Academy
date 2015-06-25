//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:

//a	    b	    GCD(a, b)
//3	    2	    1
//60	40	    20
//5	    -15 	5

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        int GCD = 0;
        int n = 0;

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                n = b;
                b = a;
                a = n;
            }
            while (b != 0)
            {
                GCD = a % b;
                a = b;
                if (GCD == 0)
                {
                    GCD = b;
                    b = 0;
                }
                else
                {
                    b = GCD;
                }
            }
        }
        Console.WriteLine(GCD);
    }
}
