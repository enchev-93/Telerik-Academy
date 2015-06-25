//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        char[] reversedStr = str.ToCharArray();
        Array.Reverse(reversedStr);
        str = new string(reversedStr);
        Console.WriteLine(reversedStr);
    }
}
