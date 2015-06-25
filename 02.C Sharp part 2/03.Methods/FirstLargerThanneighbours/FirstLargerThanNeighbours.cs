//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that
//is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        // uncomment to check for the first position
        int[] arr = { 1, 2, 3, 4, 5};//, 3, 3, 7, 1, 2, 3, 8, 4, 6, 7, 2, 3, 5, 9, 8 };
        int position = NeighbourChecker(arr);
        if (position > 0)
        {
            Console.WriteLine("The element is on position {0}", position);
        }
        else
        {
            Console.WriteLine("No such element exists!");
        }
    }

    static int NeighbourChecker(int[] arr)
    {
        int position = -1;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                position = i;
                break;
            }
        }
        return position;
    }
}
