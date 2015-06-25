//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by
//the length of its elements (the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        string[] arr = { "Doncho", "Pesho", "Ivo", "Evlogi", "Kristian", "Niki" };

        //Console.WriteLine("Enter size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //string[] arr = new string[n];

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write("string [{0}]: ", i);
        //    arr[i] = Console.ReadLine();
        //}

        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
