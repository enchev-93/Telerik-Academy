//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as 
//arrays of digits (each array element arr[i] contains a digit; the last 
//digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class NumberAsArray
{
    static void Main()
    {
        int[] firstArr = { 1, 1, 1 };
        int[] secondArr = { 9, 9, 9 };
        string res = "";
        int[] result = ArraySum(firstArr, secondArr);

        for (int i = result.Length - 1; i >= 0; i--)
        {
            res += result[i];
        }

        Console.WriteLine("The new arrays is: {0}", res);
    }

    static int[] ArraySum(int[] firstArr, int[] secondArr)
    {
        int[] newArr = new int[firstArr.Length + 1];
        int sum = 0;
        int next = 0;

        for (int i = 0; i < firstArr.Length; i++)
        {
            sum = firstArr[i] + secondArr[i];
            newArr[i] = (sum % 10) + next;

            if (sum < 10)
            {
                next = 0;
            }
            else
            {
                next = 1;
            }
        }

        if (next == 1)
        {
            newArr[firstArr.Length] = 1;
        }

        return newArr;
    }
}