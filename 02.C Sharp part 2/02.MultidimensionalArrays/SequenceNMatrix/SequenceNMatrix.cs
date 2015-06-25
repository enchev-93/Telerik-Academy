//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;

class SequenceNMatrix
{
    static void Main()
    {
        // uncomment to enter your matrix
        //Console.Write("Enter number of rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Enter number of colums: ");
        //int cols = int.Parse(Console.ReadLine());

        //string[,] matrix = new string[rows, cols];

        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        Console.Write("matrix[{0},{1}] = ", row, col);
        //        string element = Console.ReadLine();
        //        matrix[row, col] = element;
        //    }
        //}

        string[,] matrix = 
            {
                {"ha",	"fifi",	"ho",	"hi"},
                {"fo",	"ha",	"hi",	"xx"},
                {"xxx",	"ho",	"ha",	"xx"}
            };

        //string[,] matrix = 
        //    {
        //        {"s",	"qq",	"s"},
        //        {"pp",	"pp",	"s"},
        //        {"pp",	"qq",	"s"}
        //    };

        int maxSum = 0;
        List<string> result = new List<string>();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                #region horizontalSum
                int horizontalSum = 0;
                for (int i = 0; i < matrix.GetLength(1) - col; i++)
                {
                    if (matrix[row, col] == matrix[row, col + i])
                    {
                        horizontalSum++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (horizontalSum > maxSum)
                {
                    maxSum = horizontalSum;
                    result.Clear();
                    result.Add(matrix[row, col]);
                }
                else if (horizontalSum == maxSum)
                {
                    result.Add(matrix[row, col]);
                }
                #endregion

                #region verticalSum
                int verticalSum = 0;
                for (int i = 0; i < matrix.GetLength(0) - row; i++)
                {
                    if (matrix[row, col] == matrix[row + i, col])
                    {
                        verticalSum++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (verticalSum > maxSum)
                {
                    maxSum = verticalSum;
                    result.Clear();
                    result.Add(matrix[row, col]);
                }
                else if (horizontalSum == maxSum)
                {
                    result.Add(matrix[row, col]);
                }
                #endregion

                #region diagonalSum
                int diagonalSum = 0;
                for (int i = 0, j = 0; i < matrix.GetLength(0) - row && j < matrix.GetLength(1) - col; i++, j++)
                {
                    if (matrix[row, col] == matrix[row + i, col + j])
                    {
                        diagonalSum++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (diagonalSum > maxSum)
                {
                    maxSum = diagonalSum;
                    result.Clear();
                    result.Add(matrix[row, col]);
                }
                else if (diagonalSum == maxSum)
                {
                    result.Add(matrix[row, col]);
                }
                #endregion
            }
        }
        if (maxSum > 1)
        {
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("{0} repeats {1} times.", result[i], maxSum);
            }
        }
        else
        {
            Console.WriteLine("No sequence found.");
        }
    }
}
