//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of
//a group of n different elements (also known as the number of combinations)
//is calculated by the following formula: formula For example, there 
//are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for 
//given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	    k	n! / (k! * (n-k)!)
//3	    2	    3
//4	    2	    6
//10	6	    210
//52	5	    2598960

using System;

class ThirdCalculate
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        double num = n - k;
        double sum = 1;
        double a = 1;
        double b = 1;
        
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1 + k; i <= n; i++)
            {
                a *= i;
            }
            for (int j = 1; j <= num; j++)
            {
                b *= j;
            }
            sum = a / b;
        }
        else
        {
            Console.WriteLine("Sorry, enter correct number.");
        }
        Console.WriteLine(sum);
    }
}
