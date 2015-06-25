//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int rows = 0;
        int cols = 0;
        int counter = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = counter++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = counter++;
            }
        }


        for (rows = 0; rows < n; rows++)
        {
            for (cols = 0; cols < n; cols++)
            {
                Console.Write("{0,3} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}
