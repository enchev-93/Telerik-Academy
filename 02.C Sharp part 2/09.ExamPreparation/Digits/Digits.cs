using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Digits
{
    static int[,] digits;

    static List<bool> InitiliseListOfPattern()
    {
        var list = new List<bool[]>();

    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        digits = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');
            for (int col = 0; col < currentLine.Length; col++)
            {
                digits[row, col] = int.Parse(currentLine[col]);
            }
        }

        int sum = 0;

        for (int row = 0; row < n - 5; row++)
        {
            for (int col = 0; col < n - 3; col++)
            {
            }
        }
    }
}
