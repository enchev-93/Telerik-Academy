//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] spiral = new int[n, n];

        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol++;
                direction = "right";
            }
            else if (direction == "right" && (currentCol >= n|| spiral[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0|| spiral[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0|| spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "down";
            }

            spiral[currentRow, currentCol] = i;

            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", spiral[i, j]);
            }
            Console.WriteLine();
        }
    }
}