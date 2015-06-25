//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of 
//integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    static void Main()
    {
        int[] arr = { 1, -2, 123, 3, 8, 9, 10, 12, 9, 42, 14 };

        Console.Write("Enter starting index: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("The max element in the portion of the array is: ");
        Console.WriteLine(arr[FindMaxElement(arr, num, false)]);

        Console.WriteLine("Ascending order: ");
        Sort(arr, num);
        Print(arr, num);

        Console.WriteLine("Descending order: ");
        Sort(arr, num, false);
        Print(arr, num);
    }

    static int FindMaxElement(int[] arr, int index, bool ascending = true)
    {
        int best = index;
        for (index++; index < arr.Length; index++)
        {
            if (ascending)
            {
                if (arr[index] < arr[best])
                {
                    best = index;
                }
            }
            else
            {
                if (arr[index] > arr[best])
                {
                    best = index;
                }
            }
        }
        return best;
    }

    static void Sort(int[] arr, int num, bool ascending = true)
    {

        for (int i = num; i < arr.Length; i++)
        {
            Swap(arr, i, FindMaxElement(arr, i, ascending));
        }
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void Print(int[] arr, int num)
    {
        for (int i = num; i < arr.Length; i++)
        {
            Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
        }
    }
}
