//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range 
//[1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class PrimeNumbers
{
    static void Main()
    {
        int n = 10000001;
        int[] arr = new int[n];

        var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        var fullFileName = Path.Combine(desktopFolder, "PrimeNumbers.txt");
        StreamWriter primes = new StreamWriter(fullFileName);

        for (int i = 0; i < n; i++)
        {
            arr[i] = i;
        }

        int prime = 2;
        Console.WriteLine("The prime numbers are priting, be patient!");

        while (true)
        {
            int i = 2;
            while (prime * i < n)
            {
                arr[prime * i] = 0;
                i++;
            }

            bool finished = true;
            i = prime;

            while (i < n / 2)
            {
                i++;
                if (arr[i] != 0)
                {
                    prime = i;
                    finished = false;
                    break;
                }
            }

            if (finished)
            {
                break;
            }
        }

        using (primes)
        {
            for (int i = 2; i < 10000000; i++)
            {
                if (arr[i] != 0)
                {
                    primes.Write("{0}, ", i);
                }
            }
        }
        Console.WriteLine("Check your desktop, there should be a .txt file with the prime numbers!");
    }
}
