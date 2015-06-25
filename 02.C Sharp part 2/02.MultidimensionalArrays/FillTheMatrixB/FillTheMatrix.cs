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
        int counter = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}
