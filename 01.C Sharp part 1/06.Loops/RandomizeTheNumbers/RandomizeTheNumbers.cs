//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:

//n	    randomized numbers 1…n
//3	    2 1 3
//10    3 4 8 2 6 7 9 1 10 5

using System;
using System.Collections.Generic;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Write("Enter n value: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbArray = new int[n];
        bool[] isPrinted = new bool[n + 1];
        Random r = new Random();
        int random = r.Next(1, n + 1);

        for (int i = 0; i < n; i++)
        {
            random = r.Next(1, n + 1);
            if (!isPrinted[random])
            {
                Console.Write("{0} ", random);
                isPrinted[random] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}
