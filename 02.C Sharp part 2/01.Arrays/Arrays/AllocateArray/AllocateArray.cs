﻿//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each 
//element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int[] arrayOf20Integers = new int[20];

        for (int i = 0; i < arrayOf20Integers.Length; i++)
        {
            arrayOf20Integers[i] = i * 5;
            Console.Write(arrayOf20Integers[i] + " ");
        }
        Console.WriteLine();
    }
}
