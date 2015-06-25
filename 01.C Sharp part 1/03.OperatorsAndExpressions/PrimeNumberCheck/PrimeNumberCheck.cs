//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Examples:

//n 	Prime?
//1	    false
//2	    true
//3	    true
//4	    false
//9	    false
//97	true
//51	false
//-3	false
//0	    false

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Chose a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        int k = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                k++;
            }
        }

        if (k == 2)
        {
            Console.WriteLine("{0}! The entered number is prime.", isPrime);
        }
        else
        {
            Console.WriteLine("{0}! The entered number is not prime.", !isPrime);
        }
    }
}
