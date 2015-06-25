//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                result
//3, 2, 3, 4, 2, 2, 4	2, 3, 4

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //string input = Console.ReadLine();
        //string[] numbersString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //int[] arr = new int[numbersString.Length];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(numbersString[i]);
        //}
        // uncomment this to try with diffrent arrays, and comment the one bellow
        int[] arr = { 3, 2, 3, 4, 5, 6, 7, 2, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11 };

        int sequence = 1;
        int longestSequence = 0;
        int lastNumber = 0;
        int startedSequence = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1] + 1)
            {
                sequence++;
                startedSequence = 1;
                if (sequence > longestSequence)
                {
                    longestSequence = sequence;
                    if (startedSequence == 1)
                    {
                        lastNumber = arr[i];
                        startedSequence = 0;
                    }
                }
            }
            else
            {
                sequence = 1;
                startedSequence = 0;
            }
        }
        for (int i = 1; i <= longestSequence; i++)
        {
            Console.Write(lastNumber - longestSequence + i + " ");
        }
        Console.WriteLine();
    }
}
