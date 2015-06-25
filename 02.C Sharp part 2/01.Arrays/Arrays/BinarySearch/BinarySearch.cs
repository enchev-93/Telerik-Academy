//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        //Console.Write("Enter the size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Enter {0} element: ", i);
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        int[] arr = { 5, 3, 1, 2, 4 };

        Array.Sort(arr);

        Console.WriteLine("The sorted array: " + string.Join(", ", arr));
        Console.Write("Enter the integer you want to find the index for: ");
        int key = int.Parse(Console.ReadLine());

        int iMax = arr.Length - 1;
        int iMin = 0;
        int iMid = arr.Length / 2;
        bool keyFound = false;

        while (iMax >= iMin)
        {
            iMid = (iMin + iMax) / 2;
            if (arr[iMid] == key)
            {
                Console.WriteLine("Key = {0} found at index {1}", key, iMid);
                keyFound = true;
                break;
            }
            else if (arr[iMid] <= key)
            {
                iMin = iMid + 1;
            }
            else
            {
                iMax = iMid - 1;
            }
        }
        if (!keyFound)
        {
            Console.WriteLine("Key = {0} not found.", key);
        }
    }
}
