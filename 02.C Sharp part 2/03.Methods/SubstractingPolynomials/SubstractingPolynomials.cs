//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;

class AddingPolynomials
{
    static void Main()
    {
        int[] firstPolynom = { 2, -3 };
        int[] secondPolynom = { 4, 5, 6 };
        int[] result = new int[Math.Max(firstPolynom.Length, secondPolynom.Length)];

        Console.Write("First polynom: ");
        PrintPolynom(firstPolynom);
        Console.Write("Second polynom: ");
        PrintPolynom(secondPolynom);
        result = SumOfPolynom(firstPolynom, secondPolynom, result);
        Console.Write("Substract: ");
        PrintPolynom(result);

        int[] multiply = new int[(firstPolynom.Length + secondPolynom.Length)];
        result = MultiplicationOfPolynom(firstPolynom, secondPolynom, multiply);
        Console.Write("Multiplication: ");
        PrintPolynom(result);
    }

    static int[] SumOfPolynom(int[] firstPolynom, int[] secondPolynom, int[] result)
    {
        if (firstPolynom.Length > secondPolynom.Length)
        {
            return SumOfPolynom(secondPolynom, firstPolynom, result);
        }

        int i = 0;
        for (; i < firstPolynom.Length; i++)
        {
            result[i] = firstPolynom[i] + secondPolynom[i];
        }

        for (; i < secondPolynom.Length; i++)
        {
            result[i] = secondPolynom[i];
        }
        return result;
    }

    static int[] MultiplicationOfPolynom(int[] firstPolynom, int[] secondPolynom, int[] result)
    {
        for (int i = 0; i < secondPolynom.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPolynom.Length; i++)
        {
            for (int j = 0; j < secondPolynom.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolynom[i] + secondPolynom[j]);
            }
        }
        return result;
    }

    static void PrintPolynom(int[] polynom)
    {
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            if (polynom[i] != 0 && i != 0)
            {
                if (i == 1)
                {
                    Console.Write("{0}x + ", polynom[i]);
                }
                else if (polynom[i - 1] >= 0)
                {
                    Console.Write("{0}x^{1} + ", polynom[i], i);
                }

                else
                {
                    Console.Write("{0}x^{1} ", polynom[i], i);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynom[i]);
            }
        }
        Console.WriteLine();
    }
}

