//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and
//an integer K, sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = { 5, 20, 31, 1, 151, 232, 10, 14, 84, 35, 63, 89, 1231, 2, 5, 90 };

        //Console.WriteLine("Enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("element [{0}]: ", i);
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        int currentBigNumber = int.MinValue;
        int index = 0;

        Array.Sort(arr);
        Console.Write("Enter number to see the largest and closest to it: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= k && arr[i] > currentBigNumber)
            {
                currentBigNumber = arr[i];
                index = Array.BinarySearch(arr, currentBigNumber);
            }
        }
        Console.WriteLine(arr[index]);
    }
}
