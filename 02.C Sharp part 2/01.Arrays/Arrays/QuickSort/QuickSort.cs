//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 1, 10, 203, 13, -5, 17, 23, 9, 190, 851, 34, 81, 2, -123, 98, 36, 91 };
        Console.WriteLine("Before quick sort:\n" + string.Join(", ", arr));
        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine("After quick sort:\n" + string.Join(", ", arr));
    }

    static public int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }
            while (arr[right] > pivot)
            {
                right--;
            }
            if (arr[right] == pivot && arr[left] == pivot)
            {
                left++;
            }
            if (left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort(arr, pivot + 1, right);
            }
        }
    }
}
