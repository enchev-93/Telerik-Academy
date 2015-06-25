//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

using System;

class FrequentNumber
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int count = 0, maxCount = 0, number = 0, mostNumber = 0;

        Array.Sort(arr);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (number == arr[i] || i == 0)
            {
                number = arr[i];
                count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostNumber = arr[i];
            }

            if (arr.Length - 1 > i && arr[i + 1] != number)
            {
                number = arr[i + 1];
                count = 0;
            }
        }
        Console.WriteLine("{0} ({1} times)", mostNumber, maxCount);
    }
}
