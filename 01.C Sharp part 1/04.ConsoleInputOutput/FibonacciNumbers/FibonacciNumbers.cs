//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console
//the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) :
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

//Examples:

//n	        comments
//1     	0
//3	        0 1 1
//10	    0 1 1 2 3 5 8 13 21 34

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how long you want the Fibonacci Numbers");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 0;

        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine("{0}, {1}",
                a, b);
        }
        else if (n <= 0)
        {
            Console.WriteLine("Enter valid number!");
        }
        else
        {
            Console.Write("{0}, ", a);
            Console.Write("{0}, ", b);
            for (int i = 0; i < n - 2; i++)
            {
                c = a + b;
                Console.Write("{0}, ", c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
