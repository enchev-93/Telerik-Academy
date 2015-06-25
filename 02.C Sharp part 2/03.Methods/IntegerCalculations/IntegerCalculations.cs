//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

class IntegerCalculations
{
    static void Main()
    {
        int[] arr = {1, 5, 3, 6, 8, 1, 3, 8, 1, -2, 14, 88, 1283928, -1223371};
        Console.WriteLine("Min: {0}", Minimum(arr));
        Console.WriteLine("Max: {0}", Maximum(arr));
        Console.WriteLine("Sum: {0}", Sum(arr));
        Console.WriteLine("Average: {0}", Average(arr));
        Console.WriteLine("Product: {0}", Product(arr));
    }

    static int Minimum(int[] arr)
    {
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }

    static int Maximum(int[] arr)
    {
        int max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }

    static double Average(int[] arr)
    {
        double average = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        average /= (double)arr.Length;
        return average;
    }

    static int Sum(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static int Product(int[] arr)
    {
        int product = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}
