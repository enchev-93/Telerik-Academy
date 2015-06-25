//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically
//(letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter first char array: ");
        char[] firstCharArray = Console.ReadLine().ToCharArray();

        Console.Write("Enter second char array: ");
        char[] secondCharArray = Console.ReadLine().ToCharArray();

        string lexicographicallyFirst = string.Join("", firstCharArray);
        int length = Math.Min(firstCharArray.Length, secondCharArray.Length);

        for (int i = 0; i < length; i++)
        {
            if (firstCharArray[i] > secondCharArray[i])
            {
                lexicographicallyFirst = string.Join("", secondCharArray);
                break;
            }
        }

        Console.WriteLine("Lexicographically first is: {0}", lexicographicallyFirst);
    }
}
