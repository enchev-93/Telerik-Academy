﻿using System;

class MaximalSum
{
    static void Main()
    {
        //•	Write a program that finds the sequence of maximal sum in given array.

        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        long maxSum = array[0];
        long currentSum = array[0];
        int currentSeqStart = 0;
        int maxSumSeqStart = 0;
        int maxSumSeqLength = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                continue;
            }
            if ((currentSum + array[i] > currentSum) || (array[i - 1] >= array[i]))
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumSeqStart = currentSeqStart;
                    maxSumSeqLength++;
                }
            }
            else
            {
                i++;
                currentSeqStart = i;
                currentSum = array[i];
            }
        }

        int[] maxSequence = new int[maxSumSeqLength];
        for (int i = 0; i < maxSequence.Length; i++)
        {
            maxSequence[i] = array[maxSumSeqStart + i];
        }

        Console.WriteLine("The max sum is {0}.", maxSum);
        Console.WriteLine("Sequence in the array [{0}] is [{1}]", String.Join(", ", array), String.Join(", ", maxSequence));
    }
}



////Problem 8. Maximal sum

////Write a program that finds the sequence of maximal sum in given array.
////Example:

////input	                                 result
////2, 3, -6, -1, 2, -1, 6, 4, -8, 8	     2, -1, 6, 4

//using System;

//class MaximalSum
//{
//    static void Main()
//    {
//        int[] nums = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

//        int maxSum = 0, currentSum = 0;

//        for (int i = 0; i < nums.Length; i++)
//        {
//            currentSum = nums[i] + currentSum;

//            if (currentSum > maxSum)
//            {
//                maxSum = currentSum;
//            }

//            if (currentSum < 0)
//            {
//                currentSum = 0;
//            }
//        }
//        Console.WriteLine("The max sum in the array is: {0}", maxSum);
//    }
//}
