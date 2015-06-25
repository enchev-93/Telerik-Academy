//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given 
//array of integers is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 6, 5, 3, 3, 7, 1, 2, 3, 8, 4, 6, 7, 2, 3, 5, 9, 8 };
        Console.Write("Enter position you want to check: ");
        int position = int.Parse(Console.ReadLine());
        if (NeighbourChecker(arr, position))
        {
            Console.WriteLine("{0} is grater than {1} and {2}", arr[position], arr[position - 1], arr[position + 1]);
        }
        else
        {
            Console.WriteLine("{0} is not grater than {1} and {2}", arr[position], arr[position -1], arr[position + 1]);
        }
    }

    static bool NeighbourChecker(int[] arr, int position)
    {
        bool isGreater = false;
        if (position < arr.Length && position > 0)
        {
            if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                isGreater = true;
            }
        }
        else
        {
            Console.WriteLine("No neighbours to compare!");
            Environment.Exit(1);
        }
        return isGreater;
    }
}
