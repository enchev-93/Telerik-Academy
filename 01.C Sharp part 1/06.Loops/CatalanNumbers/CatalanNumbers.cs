//Problem 8. Catalan Numbers

//Write a program to calculate the n-th Catalan number by given n (1 < n < 100).
//Examples:

//n	    Catalan(n)
//0	    1
//5	    42
//10	16796
//15	9694845

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter how long you want Catalan numbers: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        BigInteger divideFactorial = 1;

        if (n < 0 )
        {
            Console.WriteLine("Enter positive intiger!");
            return;
        }
        if (n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)    //calculates (2 * n)! / (n+1)!
            {
                factorial *= i;
            }
            for (int i = 1; i <= n; i++)           //calculates n!
            {
                divideFactorial *= i;
            }
            BigInteger sum = factorial / divideFactorial;   // calculates by the catalan formula: (2n)! / ((n + 1)!n!)
            Console.WriteLine("The Catalan number for n = {0} is: {1}",
                n, sum);
        }
        else
        {
            Console.WriteLine("I can not calculate such big numbers.");
        }
    }
}
