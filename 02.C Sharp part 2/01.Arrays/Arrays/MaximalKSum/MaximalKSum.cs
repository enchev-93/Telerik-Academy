//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter number for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number for k: ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter {0} element for the array: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        int result = 0;
        for (int i = arr.Length - 1; i > arr.Length - 1 - k; i--)
        {
            result += arr[i];
            Console.Write(arr[i]);
            if (i == arr.Length - k)
            {
                Console.Write(" = ");
            }
            else
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine(result);
    }
}
