//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;
using System.Collections.Generic;

class FactorialN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = { 1 };

        for (int i = 1; i <= n; i++)
        {
            arr = Multiplier(arr, i);
        }

        Console.Write("n! = ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }

    static int[] Multiplier(int[] arr, int value)
    {
        BigInteger num = new BigInteger();

        for (int i = 0; i < arr.Length; i++)
        {
            num += arr[i] * (BigInteger)Math.Pow(10, arr.Length - i - 1);
        }

        num *= value;

        List<int> l = new List<int>();

        while (num != 0)
        {
            l.Add((int)(num % 10));
            num /= 10;
        }

        int[] res = l.ToArray();
        Array.Reverse(res);

        return res;
    }
}