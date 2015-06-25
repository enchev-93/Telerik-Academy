//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class ApperanceCount
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 6, 5, 3, 3, 7, 1, 2, 3, 8, 4, 6, 7, 2, 3, 5, 9, 8 };
        Console.Write("Enter a number you want to check: ");
        int number = int.Parse(Console.ReadLine());
        int count = Counter(arr, number);
        Console.WriteLine("{0} appears {1} times in the array.", number, count);
    }

    static int Counter(int[] arr, int number)
    {
        int count = 0;
        foreach (var num in arr)
        {
            if (arr[num] == number)
            {
                count++;
            }
        }

        return count;
    }
}
